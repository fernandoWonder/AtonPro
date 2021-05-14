using Appplication.Controller;
using Appplication.Controller.Assistents;
using Domain.Domain.Entities;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.ProductAssistant;
using Domain.Domain.Saft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Statics
{
    public class preencherDadosSaft
    {
        AuditFile auditFile { get; set; }
        DateTime dataInicio;
        DateTime dataFinal;
        SystemInfo systemInfo = SystemInfoCurrent.SystemInfo;
        Company company = SystemInfoCurrent.getCurrentCompany();
        Customer finalCustomer = new CustomerController().getOne(1);

        
        string fDateT = "yyyy-MM-ddTHH:mm:ss";

        /*IEnumerable<IGrouping<int, ProductSales>> groupListProduct;
        IEnumerable<IGrouping<int, ProductSales>> groupListProductCustomer;
        IEnumerable<IGrouping<int, ProductSales>> groupListProductInvoice;*/

        CustomerController _customerController = new CustomerController();
        ProductSalesController _productSalesController = new ProductSalesController();
        InvoiceController _invoiceController = new InvoiceController();

        public preencherDadosSaft(DateTime dataInicio, DateTime dataFinal)
        {
            this.dataFinal = dataFinal;
            this.dataInicio = dataInicio;
        }

        public AuditFile getAduditFile()
        {
            // AuditFileHeader: Completo
            auditFile = new AuditFile()
            {
                Header = getHeader(),
                MasterFiles = masterFiles(),
                SourceDocuments = SourceDocuments()
            };

            return auditFile;
        }

        private AuditFileHeader getHeader()
        {
            company = new CompanyController().getOne(company.Id);
            string siglaPais = new CountryController().getOne(company.Cidade.PaisId).Sigla;

            return new AuditFileHeader()
            {
                AuditFileVersion = systemInfo.AudiFileVersion,
                BusinessName = company.Empresa,
                CompanyAddress = new AuditFileHeaderCompanyAddress()
                {
                    AddressDetail = company.Endereco,
                    City = company.Cidade.Cidade,
                    Country = siglaPais,
                },
                CompanyName = company.Empresa,
                CompanyID = company.CompanyID,
                CurrencyCode = "AOA",

                Email = company.Email,
                DateCreated = DateTime.Now,//.ToString(fDate),
                EndDate = dataFinal,//.ToString(fDate),
                StartDate = dataInicio,//.ToString(fDate),
                Fax = company.Fax,
                Telephone = company.Tel,
                Website = company.UrlSite,
                FiscalYear = systemInfo.FiscalYear,
                TaxRegistrationNumber = company.Nif,

                ProductCompanyTaxID = systemInfo.ProductCompanyTaxID,
                ProductVersion = systemInfo.SystemVersion,
                ProductID = systemInfo.ProductID,

                TaxEntity = "Global",
                SoftwareValidationNumber = "CJ" + systemInfo.SoftwareValidationNumber,
                TaxAccountingBasis = systemInfo.TaxAccountBasis,
            };
        }

        public AuditFileMasterFiles masterFiles()
        {

            var groupListProduct = _productSalesController.ListALL().
                Where(c => c.DataCadastro.Date >= dataInicio.Date && c.DataCadastro.Date <= dataFinal.Date && c.Fatura.TipoDocumento.SalesInvoices).ToList().
                GroupBy(c => c.ProductId);

            var groupListProductCustomer = _productSalesController.ListALL().
                Where(c => c.DataCadastro.Date >= dataInicio.Date && c.DataCadastro.Date <= dataFinal.Date && c.Fatura.TipoDocumento.SalesInvoices).ToList().
                GroupBy(c => c.Fatura.ClienteId);

            AuditFileMasterFilesProduct[] auditFileProduct = new AuditFileMasterFilesProduct[groupListProduct.Count()];
            AuditFileMasterFilesCustomer[] auditFileCustomer = new AuditFileMasterFilesCustomer[groupListProductCustomer.Count()];

            AuditFileMasterFilesTaxTableEntry[] auditTaxTable;

            /* foreach (var item in groupList)
             {

                 Console.WriteLine(item.Key);
                 foreach (var prodSale in item)
                 {
                     Console.WriteLine(" * - " + prodSale.Product.Descricao);
                 }
             }*/

            List<TabelaImposto> tabela_taxas = new List<TabelaImposto>();
            int i = 0;
            string imposto;
            string impostoType;
            string impostoDescricao;
            foreach (var item in groupListProduct)
            {
                ProductSales p = item.ToList()[0];
                string cod = p.Product.Codigo_Barra != "" &&
                    p.Product.Codigo_Barra != null
                    ? p.Product.Codigo_Barra : p.Product.Id.ToString();

                auditFileProduct[i] = new AuditFileMasterFilesProduct()
                {
                    ProductCode = p.Product.Id.ToString(),
                    ProductDescription = p.Descricao_Produto,
                    ProductType = p.Product.TipoArtigo.Tipo,
                    ProductNumberCode = cod,
                    ProductGroup = p.Product.Categoria.Categoria
                };

                imposto = p.Product.CodigoTaxa.Code;
                impostoType = p.Product.CodigoTaxaId == 3 ? "NS" :  "IVA";
                impostoDescricao = p.Product.CodigoTaxa.Descricao;

                tabela_taxas.Add(new TabelaImposto()
                {
                    TaxType = impostoType,
                    TaxCode = imposto,
                    TaxCodeDescription = impostoDescricao,
                    Taxa = decimal.Parse(p.Taxa.ToString()),
                });
                i++;
            }

            var groupTabela_taxas = tabela_taxas.GroupBy(c => c.TaxCode).ToList();
            auditTaxTable = new AuditFileMasterFilesTaxTableEntry[groupTabela_taxas.Count()];
            i = 0;
            foreach (var item in groupTabela_taxas)
            {
                auditTaxTable[i] = new AuditFileMasterFilesTaxTableEntry()
                {
                    TaxType = item.ToList()[0].TaxType,
                    TaxCountryRegion = "AO",
                    TaxCode = item.ToList()[0].TaxCode,
                    TaxPercentage = item.ToList()[0].Taxa.ToString("F3").Replace(",", "."),
                    Description = item.ToList()[0].TaxCodeDescription,
                };
                i++;
            }

            List<Customer> _customers = new List<Customer>();
            i = 0;
            int contFinal = 0;
            foreach (var item in groupListProductCustomer)
            {
                Customer c = item.ToList()[0].Fatura.Cliente;

                if ((c.Nif.Contains("9999999") || c.Nif == string.Empty))
                    contFinal++;

                bool isOnlist = false;
                foreach (var itemCustomer in _customers)
                {
                    if (itemCustomer.Id == c.Id)
                        isOnlist = true;
                }

                if (!isOnlist)
                {
                    if ((c.Nif.Contains("9999999") || c.Nif == string.Empty) && contFinal == 1)
                        _customers.Add(finalCustomer);
                    else if (!c.Nif.Contains("9999999") && c.Nif.Length > 6)
                        _customers.Add(c);
                    else
                    {
                        isOnlist = true;
                    }
                }

                if (!isOnlist)
                {
                    bool finalCl = c.Nif == string.Empty || c.Nif.Contains("9999999");

                    string endereco = c.Endereco != null && c.Endereco != "" ? c.Endereco : "Nao definido";

                    string contaCorrente = c.Conta_Corrente != null && c.Conta_Corrente != string.Empty ? c.Conta_Corrente : "Desconhecido";
                    string siglaPais = new CountryController().getOne(c.Cidade.PaisId).Sigla;

                    auditFileCustomer[i] = new AuditFileMasterFilesCustomer()
                    {
                        CustomerID = finalCl ? finalCustomer.Id.ToString() : c.Id.ToString(),
                        CustomerTaxID = finalCl ? finalCustomer.Nif : c.Nif,
                        CompanyName = finalCl ? finalCustomer.Cliente : c.Cliente,
                        SelfBillingIndicator = "0",
                        AccountID = finalCl ? finalCustomer.Conta_Corrente : contaCorrente,
                        BillingAddress = new AuditFileMasterFilesCustomerBillingAddress()
                        {
                            City = finalCl ? finalCustomer.Cidade.Cidade : c.Cidade.Cidade,
                            Country = finalCl ? "AO" : siglaPais,
                            PostalCode = finalCl ? finalCustomer.Postal : c.Postal,
                            AddressDetail = finalCl ? "Nao definido" : endereco,
                        },
                                                
                    };
                    i++;
                }
                
            }

            return new AuditFileMasterFiles()
            {
                Product = auditFileProduct,
                Customer = auditFileCustomer,
                TaxTable = auditTaxTable,

            };
        }

        public AuditFileSourceDocuments SourceDocuments()
        {
            return new AuditFileSourceDocuments()
            {
                SalesInvoices = getSalesInvoices(),
                MovementOfGoods = new AuditFileSourceDocumentsMovementOfGoods()
                {
                    NumberOfMovementLines = "0",
                    TotalQuantityIssued = "0.00",
                },
                WorkingDocuments = getWorkDocuments(),
                Payments = getPayments(),
            };
        }

        public AuditFileSourceDocumentsSalesInvoices getSalesInvoices()
        {
            var groupListProductInvoice = _productSalesController.ListALL().
                Where(c => c.DataCadastro.Date >= dataInicio.Date && c.DataCadastro.Date <= dataFinal.Date && c.Fatura.TipoDocumento.SalesInvoices).ToList().
                GroupBy(c => c.FaturaId).ToList();

            //AuditFileSourceDocumentsMovementOfGoods[] auditmovmentsOfGood = new AuditFileSourceDocumentsMovementOfGoods[];
            AuditFileSourceDocumentsSalesInvoicesInvoice[] listSalesInvoices = new AuditFileSourceDocumentsSalesInvoicesInvoice[groupListProductInvoice.Count()];

            decimal totalDebit = 0;
            decimal totalCredit = 0;
            int i = 0;

            foreach (var item in groupListProductInvoice)
            {
                Invoice iv = item.ToList()[0].Fatura;
                bool notaCreditoOuDebito = iv.TipoDocumento.Id == "10" || iv.TipoDocumento.Id == "9";

                if (iv.InvoiceStatusId != 3 /*Doc. Anulado*/ && iv.InvoiceStatusId != 5 /*Doc. faturado*/)
                {
                    if(notaCreditoOuDebito)
                        totalDebit += iv.TotalIncidencia;
                    else
                        totalCredit += iv.TotalIncidencia;
                }
                
                AuditFileSourceDocumentsSalesInvoicesInvoiceLine[] linesInvoice = new AuditFileSourceDocumentsSalesInvoicesInvoiceLine[iv.ProductsSales.Count()];

                int j = 0;
                foreach (var lineProduct in iv.ProductsSales)
                {
                    string imposto = lineProduct.Product.CodigoTaxa.Code;
                    string impostoType = lineProduct.Product.CodigoTaxaId == 3 ? "NS" : "IVA";
                    TaxReasonExemption taxReason = null;

                    taxReason = lineProduct.Product.MotivoISEId != null ? new TaxReasonExemptionController().getOne(lineProduct.Product.MotivoISEId) : null;
                    bool showCreditField = true;
                    AuditFileSourceDocumentsSalesInvoicesInvoiceLineReferences references = null;

                    if (notaCreditoOuDebito)
                    {
                        showCreditField = false;
                        references = new AuditFileSourceDocumentsSalesInvoicesInvoiceLineReferences()
                        {
                            Reference = iv.Referencia,
                            Reason = iv.RazaoNota == string.Empty ? null : iv.RazaoNota,
                        };
                    }

                    linesInvoice[j] = new AuditFileSourceDocumentsSalesInvoicesInvoiceLine()
                    {
                        CreditAmountSpecified = showCreditField,
                        DebitAmountSpecified = !showCreditField,

                        CreditAmount = lineProduct.TotalIncidencia.ToString("F3").Replace(",", "."),
                        DebitAmount = lineProduct.TotalIncidencia.ToString("F3").Replace(",", "."),
                        Description = "bom",
                        LineNumber = (j + 1).ToString(),
                        ProductCode = lineProduct.ProductId.ToString(),
                        Quantity = lineProduct.Quantidade.ToString("F3").Replace(",", "."),
                        UnitPrice = lineProduct.Preco.ToString("F3").Replace(",", "."),
                        ProductDescription = lineProduct.Descricao_Produto,
                        UnitOfMeasure = lineProduct.Unidade,
                        Tax = new AuditFileSourceDocumentsSalesInvoicesInvoiceLineTax()
                        {
                            TaxCountryRegion = "AO",
                            TaxType = impostoType,
                            TaxPercentage = lineProduct.Taxa.ToString("F3").Replace(",", "."),
                            TaxCode = imposto,
                        },
                        References = references,
                        TaxExemptionReason = taxReason != null ? taxReason.MencaoFatura : null,
                        TaxExemptionCode = taxReason != null ? taxReason.Id : null,
                        TaxPointDate = Convert.ToDateTime(iv.InvoiceDate),
                        SettlementAmount = /*lineProduct.ValorDesconto.ToString().Replace(",", ".") */ lineProduct.ValorDesconto.ToString("F3").Replace(",", "."),
                    };

                    j++;
                }

                listSalesInvoices[i] = new AuditFileSourceDocumentsSalesInvoicesInvoice()
                {
                    CustomerID = iv.Cliente.Nif.Contains("9999999") || iv.Cliente.Nif == string.Empty ? finalCustomer.Id.ToString() : iv.ClienteId.ToString(),
                    DocumentStatus = new AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentStatus()
                    {
                        InvoiceStatus = iv.InvoiceStatus.Estado,
                        InvoiceStatusDate = iv.DataCadastro.ToString("yyyy-MM-ddTHH:mm:ss"),
                        SourceID = iv.UserId.ToString(),
                        SourceBilling = "P",
                    },
                    Hash = iv.Hash,
                    InvoiceDate = iv.InvoiceDate,
                    InvoiceNo = iv.InvoiceNo,
                    InvoiceType = iv.TipoDocumento.Tipo,
                    SourceID = iv.UserId.ToString(),
                    HashControl = systemInfo.SoftwareValidationNumber == "0" ? "0" : "1",
                    SystemEntryDate = iv.DataCadastro.ToString(fDateT),
                    Period = iv.DataCadastro.Month.ToString(),
                    DocumentTotals = new AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotals()
                    {
                        TaxPayable = iv.TotalImposto.ToString("F3").Replace(",", "."),
                        NetTotal = iv.TotalIncidencia.ToString("F3").Replace(",", "."),
                        GrossTotal = iv.TotalGeral.ToString("F3").Replace(",", "."),
                        Payment = new AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotalsPayment()
                        {
                            PaymentMechanism = iv.FormaPagamento.Id,
                            PaymentAmount = /*iv.TotalGeral.ToString("F").Replace(",", "."), */iv.ValorPago.ToString("F3").Replace(",", "."),
                            PaymentDate = Convert.ToDateTime(iv.InvoiceDate),
                        },
                    },
                    Line = linesInvoice,
                    SpecialRegimes = new AuditFileSourceDocumentsSalesInvoicesInvoiceSpecialRegimes()
                    {
                        CashVATSchemeIndicator = "0",
                        SelfBillingIndicator = "0",
                        ThirdPartiesBillingIndicator = "0"
                    },
                   /* WithholdingTax = new AuditFileSourceDocumentsSalesInvoicesInvoiceWithholdingTax()
                    {
                        WithholdingTaxType = "IRT",
                        WithholdingTaxDescription = "Aplicação da Retenção",
                        WithholdingTaxAmount = "0",
                    },
                    */
                };
                i++;
            }

            return new AuditFileSourceDocumentsSalesInvoices()
            {
                Invoice = listSalesInvoices.Count() > 0 ? listSalesInvoices : null,
                TotalCredit = totalCredit.ToString("F3").Replace(",", "."),
                TotalDebit = totalDebit.ToString("F3").Replace(",", "."),
                NumberOfEntries = listSalesInvoices.Count().ToString(),
            };
        }

        public AuditFileSourceDocumentsWorkingDocuments getWorkDocuments()
        {
            var groupListProductInvoice = _productSalesController.ListALL().
                Where(c => c.DataCadastro.Date >= dataInicio.Date && c.DataCadastro.Date <= dataFinal.Date && c.Fatura.TipoDocumento.WorkDocuments).ToList().
                GroupBy(c => c.FaturaId).ToList();

            AuditFileSourceDocumentsWorkingDocumentsWorkDocument[] listProformas = new AuditFileSourceDocumentsWorkingDocumentsWorkDocument[groupListProductInvoice.Count()];

            decimal totalCredit = 0;
            int i = 0;
            int j;

            foreach (var item in groupListProductInvoice)
            {
                Invoice iv = item.ToList()[0].Fatura;

                if (iv.InvoiceStatusId != 3 /*Doc. Anulado*/ && iv.InvoiceStatusId != 5 /*Doc. faturado*/)
                {
                    totalCredit += iv.TotalIncidencia;
                }

                AuditFileSourceDocumentsWorkingDocumentsWorkDocumentLine[] linesInvoice = new AuditFileSourceDocumentsWorkingDocumentsWorkDocumentLine[iv.ProductsSales.Count()];

                j = 0;
                foreach (var lineProduct in iv.ProductsSales)
                {
                    string imposto = lineProduct.Product.CodigoTaxa.Code;
                    string impostoType = lineProduct.Product.CodigoTaxaId == 3 ? "NS" : "IVA";
                    TaxReasonExemption taxReason = null;
                    taxReason = lineProduct.Product.MotivoISEId != null ? new TaxReasonExemptionController().getOne(lineProduct.Product.MotivoISEId) : null;


                    linesInvoice[j] = new AuditFileSourceDocumentsWorkingDocumentsWorkDocumentLine()
                    {

                        CreditAmount = lineProduct.TotalIncidencia.ToString("F3").Replace(",", "."),
                        Description = "bom",
                        LineNumber = (j + 1).ToString(),
                        ProductCode = lineProduct.ProductId.ToString(),
                        Quantity = lineProduct.Quantidade.ToString("F3").Replace(",", "."),
                        UnitPrice = lineProduct.Preco.ToString("F3").Replace(",", "."),
                        ProductDescription = lineProduct.Descricao_Produto,
                        UnitOfMeasure = lineProduct.Unidade,
                        TaxPointDate = Convert.ToDateTime(iv.InvoiceDate),
                        Tax = new AuditFileSourceDocumentsWorkingDocumentsWorkDocumentLineTax()
                        {
                            TaxCountryRegion = "AO",
                            TaxType = impostoType,
                            TaxPercentage = lineProduct.Taxa.ToString("F3").Replace(",", "."),
                            TaxCode = imposto,
                        },
                        TaxExemptionReason = taxReason != null ? taxReason.MencaoFatura : null,
                        TaxExemptionCode = taxReason != null ? taxReason.Id : null,
                        SettlementAmount = lineProduct.ValorDesconto.ToString("F3").Replace(",", "."), // lineProduct.ValorDesconto.ToString("F").Replace(",", "."),
                    };

                    j++;
                }

                listProformas[i] = new AuditFileSourceDocumentsWorkingDocumentsWorkDocument()
                {
                    CustomerID = iv.Cliente.Nif.Contains("9999999") || iv.Cliente.Nif == string.Empty ? finalCustomer.Id.ToString() : iv.ClienteId.ToString(),
                    DocumentStatus = new AuditFileSourceDocumentsWorkingDocumentsWorkDocumentDocumentStatus()
                    {
                        WorkStatus = iv.InvoiceStatus.Estado,
                        WorkStatusDate = iv.DataCadastro.ToString("yyyy-MM-ddTHH:mm:ss"),
                        Reason = iv.RazaoNota,
                        SourceID = iv.UserId.ToString(),
                        SourceBilling = "P",
                    },
                    //TransactionID
                    Hash = iv.Hash,
                    WorkDate = Convert.ToDateTime(iv.InvoiceDate),
                    DocumentNumber = iv.InvoiceNo,
                    WorkType = iv.TipoDocumento.Tipo,
                    SourceID = iv.UserId.ToString(),
                    HashControl = "0",
                    SystemEntryDate = Convert.ToDateTime(iv.DataCadastro.ToString(fDateT)),
                    Period = iv.DataCadastro.Month.ToString(),
                    DocumentTotals = new AuditFileSourceDocumentsWorkingDocumentsWorkDocumentDocumentTotals()
                    {
                        TaxPayable = iv.TotalImposto.ToString("F3").Replace(",", "."),
                        NetTotal = iv.TotalIncidencia.ToString("F3").Replace(",", "."),
                        GrossTotal = iv.TotalGeral.ToString("F3").Replace(",", "."),
                    },
                    Line = linesInvoice,
                };

                i++;

            }


            return new AuditFileSourceDocumentsWorkingDocuments() {
                TotalCredit = totalCredit.ToString("F3").Replace(",","."),
                TotalDebit = "0.00",
                NumberOfEntries = listProformas.Count().ToString(),
                WorkDocument = listProformas.Count() > 0 ? listProformas : null,
            };

        }

        public AuditFileSourceDocumentsPayments getPayments()
        {
            var listRecibos = new ReciboController().ListALL().
                Where(c => c.DataCadastro.Date >= dataInicio.Date && c.DataCadastro.Date <= dataFinal.Date).ToList();

            AuditFileSourceDocumentsPaymentsPayment[] listPayments = new AuditFileSourceDocumentsPaymentsPayment[listRecibos.Count];
            decimal totalCredit = 0;
            int i = 0;
            int j = 0;

            foreach (var item in listRecibos)
            {
                totalCredit += item.TotalRecibo;

                AuditFileSourceDocumentsPaymentsPaymentLine[] linesPayment = new AuditFileSourceDocumentsPaymentsPaymentLine[item.Payments.ToList().Count];
                j = 0;
                foreach (var line in item.Payments)
                {
                    linesPayment[j] = new AuditFileSourceDocumentsPaymentsPaymentLine()
                    {
                        CreditAmount = line.ValorPago.ToString("F3").Replace(",", "."),
                        LineNumber = (j+1).ToString(),
                        SourceDocumentID = new AuditFileSourceDocumentsPaymentsPaymentLineSourceDocumentID()
                        {
                            Description = line.Descricao,
                            OriginatingON = line.Fatura.InvoiceNo,
                            InvoiceDate = Convert.ToDateTime(line.Fatura.InvoiceDate),
                        },
                    };
                    j++;
                }

                AuditFileSourceDocumentsPaymentsPaymentPaymentMethod[] paymentMethods = new AuditFileSourceDocumentsPaymentsPaymentPaymentMethod[1];
                paymentMethods[0] = new AuditFileSourceDocumentsPaymentsPaymentPaymentMethod()
                {
                    PaymentMechanism = item.Documento.FormaPagamento.Id,
                    PaymentAmount = item.Documento.ValorPago.ToString("F3").Replace(",", "."),
                    PaymentDate = item.DataUltimoEstadoPagamento,
                };

                listPayments[i] = new AuditFileSourceDocumentsPaymentsPayment()
                {
                    Description = "Liquidação de Faturas",
                    Period = item.DataCadastro.Month.ToString(),
                    PaymentRefNo = item.Documento.InvoiceNo,
                    PaymentType = item.Documento.TipoDocumento.Tipo,
                    SystemID = item.DocumentoId.ToString(),
                    DocumentStatus = new AuditFileSourceDocumentsPaymentsPaymentDocumentStatus()
                    {
                        PaymentStatus = item.Documento.InvoiceStatus.Estado,
                        PaymentStatusDate = item.DataUltimoEstadoPagamento.ToString(fDateT),
                        SourceID = item.UserUltimoEstadoDocumentoId.ToString(),
                        SourcePayment = "P",
                    },
                    PaymentMethod = paymentMethods,
                    SystemEntryDate = item.DataUltimoEstadoPagamento.ToString(fDateT),
                    SourceID = item.UserUltimoEstadoDocumentoId.ToString(),
                    CustomerID = item.Documento.ClienteId.ToString(),
                    Line = linesPayment,
                    DocumentTotals = new AuditFileSourceDocumentsPaymentsPaymentDocumentTotals()
                    {
                        TaxPayable = "0.00",
                        NetTotal = item.TotalRecibo.ToString("F3").Replace(",", "."),
                        GrossTotal = item.TotalRecibo.ToString("F3").Replace(",", "."),
                    },
                    TransactionDate = item.DataCadastro,
                };

                i++;
            }

            return new AuditFileSourceDocumentsPayments()
            {
                TotalDebit = "0.00",
                TotalCredit = totalCredit.ToString("F3").Replace(",", "."),
                NumberOfEntries = listRecibos.Count.ToString(),
                Payment = listPayments.Count() > 0 ? listPayments : null,
            };
        }

    }
}
