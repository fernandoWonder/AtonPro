using Domain.Domain.Entities;
using Domain.Domain.Entities.Assistants;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Entities.Financial;
using Domain.Domain.Entities.ProductAssistant;
using Infrastructure.Data.Security;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Initializer
{
    public class DataSystemInitializer
    {
        public static List<SystemEntities> getSystemEntities()
        {
            return new List<SystemEntities>()
            {
                new SystemEntities()
                {
                    Id = 1,
                    Entidade = "Clientes"
                },
                new SystemEntities()
                {
                    Id = 2,
                    Entidade = "Fornecedores"
                },
                new SystemEntities()
                {
                    Id = 3,
                    Entidade = "Contas",
                }
            };
        }
        public static SystemInfo getSystemInfo()
        {
            return new SystemInfo()
            {
                Id = 1,
                CompanyName = "FENITECH- SOLUCOES INFORMATICA (SU), LDA",
                SystemVersion = "1.1.1",
                SystemName = "Aton",
                ProductCompanyTaxID = "5484013615",
                Tel = "923827772",
                UrlSite = "www.Fenitech.com",
                SoftwareValidationNumber = "0",
                TaxAccountBasis = "F", // Faturação
            };
        }
        public static List<Company> getCompanyInit()
        {
            return new List<Company>()
            {
                new Company()
                {
                    Id = 1,
                    CompanyTypeId = 1,
                    Email = "Tech.Usuarios@gmail.com",
                    Empresa = "Nome Empresa",
                    Nif = "999999999",
                    //Nif = "34544954098",
                    CidadeId = 1,
                    Endereco = "Viana",
                    CompanyID = "99999999",
                    Tel = "99999999",
                    Tel1 = "99999999",
                    Fax = "2299999999",
                    UrlLogo = "default.png",
                    UrlSite = "www.Siteempresa",
                    flagEmpresaProdutoraSistema = false,
                },
            };
        }

        public static List<CompanyType> getCompanyTypes()
        {
            return new List<CompanyType>()
            {
                new CompanyType()
                {
                    Id = 1,
                    Tipo = "Regime Geral",
                    Descricao = "Regime de sujeição a IVA",
                },
                new CompanyType()
                {
                    Id = 2,
                    Tipo = "Regime Simplificado",
                    Descricao = "",
                },
                new CompanyType()
                {
                    Id = 3,
                    Tipo = "Regime de Exclusão",
                    Descricao = "Regime de Exclusão a IVA",
                }
            };
        }
        public static List<User> getUserStandard()
        {
            string senhaKey = ConstantsPasswordKey.SharedSecret;
            string senhaAdminSeller = Crypto.EncryptStringAES("AdminSeller",senhaKey);
            string senhaAdmin = Crypto.EncryptStringAES("admin", senhaKey);
            return new List<User>() {
                 new User {
                    Id = 1,
                    Usuario = "AdminSeller",
                    Senha = senhaAdminSeller,
                    KeySenha = senhaKey,
                    Nome = "José Chico",
                    DataNascimento = DateTime.Now,
                    Sexo = "M",
                    FlagStandard = true,
                    FlagState = true,
                    FlagFirstLogin = false,
                    FlagAdmin = true,
                },
                 new User {
                    Id = 2,
                    Usuario = "admin",
                    Senha = senhaAdmin,
                    KeySenha = senhaKey,
                    Nome = "Administrador",
                    DataNascimento = DateTime.Now,
                    Sexo = "M",
                    FlagState = true,
                    FlagFirstLogin = true,
                    FlagAdmin = true,
                }
            };
        }

        public static List<TaxReasonExemption> getMotivoIsencao()
        {
            return new List<TaxReasonExemption>()
            {
                new TaxReasonExemption()
                {
                    Id = "M00",
                    MencaoFatura = "Regime transitório",
                    CodigoTaxaId = 3,
                    RegimeSimplificado = true,
                },
                new TaxReasonExemption()
                {
                    Id = "M02",
                    MencaoFatura = "Transmissão de bens e serviço não sujeita",
                    CodigoTaxaId = 3,
                    RegimeExclusao = true,
                    RegimeSimplificado = true,
                },
                new TaxReasonExemption()
                {
                    Id = "M04",
                    MencaoFatura = "IVA – Regime de não sujeição",
                    CodigoTaxaId = 3,
                    RegimeExclusao = true,
                },
                new TaxReasonExemption()
                {
                    Id = "M10",
                    MencaoFatura = "Isento nos termos da alínea a) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M11",
                    MencaoFatura = "Isento nos termos da alínea b) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M12",
                    MencaoFatura = "Isento nos termos da alínea c) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M13",
                    MencaoFatura = "Isento nos termos da alínea d) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M14",
                    MencaoFatura = "Isento nos termos da alínea e) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M15",
                    MencaoFatura = "Isento nos termos da alínea f) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M16",
                    MencaoFatura = "Isento nos termos da alínea g) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M17",
                    MencaoFatura = "Isento nos termos da alínea h) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M18",
                    MencaoFatura = "Isento nos termos da alínea i) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M19",
                    MencaoFatura = "Isento nos termos da alínea j) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M20",
                    MencaoFatura = "Isento nos termos da alínea k) do nº1 do artigo 12.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M30",
                    MencaoFatura = "Isento nos termos da alínea a) do artigo 15.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M31",
                    MencaoFatura = "Isento nos termos da alínea b) do artigo 15.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M32",
                    MencaoFatura = "Isento nos termos da alínea c) do artigo 15.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M33",
                    MencaoFatura = "Isento nos termos da alínea d) do artigo 15.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M34",
                    MencaoFatura = "Isento nos termos da alínea e) do artigo 15.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M35",
                    MencaoFatura = "Isento nos termos da alínea f) do artigo 15.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M36",
                    MencaoFatura = "Isento nos termos da alínea g) do artigo 15.º do CIVA",
                },
                new TaxReasonExemption()
                {
                    Id = "M37",
                    MencaoFatura = "Isento nos termos da alínea h) do artigo 15.º do CIVA",
                },
                 new TaxReasonExemption()
                {
                    Id = "M38",
                    MencaoFatura = "Isento nos termos da alínea i) do artigo 15.º do CIVA",
                },
            };
        }

        public static List<TaxType> getTiposTaxas()
        {
            return new List<TaxType>() {
                new TaxType()
                {
                    Id = 1,
                    Tipo = "IVA",
                    Descricao = "Imposto de Valor Acrescentado"
                },
                new TaxType()
                {
                    Id = 2,
                    Tipo = "ISE", // No Saft Tudo que é  isento o seu tipo é iva
                    Descricao = "Isenta"
                },
                /*new TaxType()
                {
                    Id = 3,
                    Tipo = "NS",
                    Descricao = "Não sujeição a IVA"
                },*/
                /*new TaxType()
                {
                    Id = 2,
                    Tipo = "IS",
                    Descricao = "Imposto de Selo"
                },*/

            };
        }

        public static List<TaxCode> getCodigosTaxa()
        {
            return new List<TaxCode>()
            {
                new TaxCode()
                {
                    Id = 1,
                    Code = "NOR",
                    Descricao = "Taxa Normal",
                    Taxa = 14,
                },
                new TaxCode()
                {
                    Id = 2,
                    Code = "ISE",
                    Descricao = "Isenta",
                    Taxa = 0,
                    TipoTaxaId = 2,
                },
                new TaxCode()
                {
                    Id = 3,
                    Code = "NS",
                    Descricao = "Isenta",
                    Taxa = 0,
                    TipoTaxaId = 2,
                },
            };
        }
        public static List<Family> getFamiles()
        {
            return new List<Family>()
            {
                new Family()
                {
                    Id = 1,
                    family = "Geral",
                },
                new Family()
                {
                    Id = 2,
                    family = "Buffe",

                },
                new Family()
                {
                    Id = 3,
                    family = "Gasosas",
                },
                new Family()
                {
                    Id = 4,
                    family = "Cervejas",
                },
                new Family()
                {
                    Id = 5,
                    family = "Salgados",
                },
                new Family()
                {
                    Id = 6,
                    family = "Sumos",
                },
                  new Family()
                {
                    Id = 7,
                    family = "Doces",
                },
            };
        }
        public static List<InvoiceStatus> getInvoiceStatus()
        {
            return new List<InvoiceStatus>()
            {
                new InvoiceStatus()
                {
                    Id = 1,
                    Estado = "N",
                    Descricao = "Normal"
                },
                new InvoiceStatus()
                {
                    Id = 2,
                    Estado = "S",
                    Descricao = "Autofaturação"
                },
                new InvoiceStatus()
                {
                    Id = 3,
                    Estado = "A",
                    Descricao = "Documento Anulado"
                },
                new InvoiceStatus()
                {
                    Id = 4,
                    Estado = "R",
                    Descricao = "Documento de Resumo doutros documentos criados noutras aplicações e gerados nesta aplicação"
                },
                new InvoiceStatus()
                {
                    Id = 5,
                    Estado = "F",
                    Descricao = "Documento Faturado"
                }
            };
        }

        public static List<InvoiceType> getInvoiceType()
        {
            return new List<InvoiceType>()
            {
                new InvoiceType()
                {
                    Id = "1",
                    Tipo = "FT",
                    Descricao = "Factura", 
                    SalesInvoices = true,
                },
                new InvoiceType()
                {
                    Id = "2",
                    Tipo = "FR",
                    Descricao = "Factura-Recibo",
                    SalesInvoices = true,
                },
               /* new InvoiceType()
                {
                    Id = 4,
                    Tipo = "GF",
                    Descricao = "Factura Generica"
                },
                new InvoiceType()
                {
                    Id = 5,
                    Tipo = "FG",
                    Descricao = "Factura Global"
                },
                new InvoiceType()
                {
                    Id = 6,
                    Tipo = "AC",
                    Descricao = "Aviso de Cobrança"
                },
                new InvoiceType()
                {
                    Id = 7,
                    Tipo = "AR",
                    Descricao = "Aviso de Cobrança/Recibo"
                },
                new InvoiceType()
                {
                    Id = "8",
                    Tipo = "RE",
                    Descricao = "Recibo"
                },*/
               
                new InvoiceType()
                {
                    Id = "10",
                    Tipo = "NC",
                    Descricao = "Nota de Crédito",
                    SalesInvoices = true,
                },
               /* new InvoiceType()
                {
                    Id = "11",
                    Tipo = "GR",
                    Descricao = "Guia de Remessa"
                },
                new InvoiceType()
                {
                    Id = "12",
                    Tipo = "AF",
                    Descricao = "Factura/Recibo (Autofaturação)"
                },
                new InvoiceType()
                {
                    Id = "13",
                    Tipo = "TV",
                    Descricao = "Talão de Venda; (a)"
                },
                new InvoiceType()
                {
                    Id = "14",
                    Tipo = "TS",
                    Descricao = "Talão de Serviços Prestados; (a)"
                },
                new InvoiceType()
                {
                    Id = "15",
                    Tipo = "TD",
                    Descricao = "Talão de Devolução; (a)"
                },
                new InvoiceType()
                {
                    Id = "16",
                    Tipo = "AA",
                    Descricao = "Alienação de activos; (a)"
                },
                new InvoiceType()
                {
                    Id = "17",
                    Tipo = "DA",
                    Descricao = "Devolução de activos; (a)"
                },*/
                new InvoiceType()
                {
                    Id = "18",
                    Tipo = "PP",
                    Descricao = "Factura Proforma",
                    SalesInvoices = false,
                    WorkDocuments = true,
                },
                new InvoiceType()
                {
                    Id = "RC",
                    Tipo = "RC",
                    Descricao = "Recibo",
                    Payments = true,
                    SalesInvoices = false,
                },

                // ========== Purchases Documents ===================
                new InvoiceType()
                {
                    Id = "FTC",
                    Tipo = "FTF",
                    Descricao = "C/Factura",
                    SalesInvoices = true,
                    Purchase = true,
                    Seller = false,
                },
                new InvoiceType()
                {
                    Id = "FRF",
                    Tipo = "FRF",
                    Descricao = "C/Factura-Recibo",
                    SalesInvoices = true,
                    Purchase = true,
                    Seller = false,
                },
                new InvoiceType()
                {
                    Id = "FPF",
                    Tipo = "FPF",
                    Descricao = "C/Factura Proforma",
                    SalesInvoices = true,
                    Purchase = true,
                    Seller = false,
                },
                new InvoiceType()
                {
                    Id = "RCF",
                    Tipo = "RCF",
                    Descricao = "V/Recibo",
                    Payments = true,
                    SalesInvoices = false,
                    Purchase = true,
                    Seller = false,
                },
                new InvoiceType()
                {
                    Id = "NCF",
                    Tipo = "NCF",
                    Descricao = "C/Nota de Crédito",
                    SalesInvoices = true,
                    Purchase = true,
                    Seller = false,
                },
            };
        }

        public static List<InvoiceNoteOperationType> getTipoDeOprecaoNota()
        {
            return new List<InvoiceNoteOperationType>()
            {
                new InvoiceNoteOperationType()
                {
                    Id = 1,
                    Operacao = "Retificação"
                },
                new InvoiceNoteOperationType()
                {
                    Id = 2,
                    Operacao = "Anulação"
                },
            };
        }

        public static List<InvoiceNoteReason> getRazoesNota()
        {
            return new List<InvoiceNoteReason>(){
                new InvoiceNoteReason()
                {
                    Id = 1,
                    Razao = "Erro de Quantidade"
                },
                new InvoiceNoteReason()
                {
                    Id = 2,
                    Razao = "Devolução",
                },
                new InvoiceNoteReason()
                {
                    Id = 3,
                    Razao = "Informações do cliente errada",
                },
            };
        }

        public static List<PaymentMechanism> getFormasPagamento()
        {
            return new List<PaymentMechanism>()
            {
                new PaymentMechanism()
                {
                    Id = "NU",
                  //  FormaPagamento = "NU",
                    Descricao = "Numerário"
                },
                new PaymentMechanism()
                {
                    Id = "CC",
                  //  FormaPagamento = "CC",
                    Descricao = "Multicaixa",
                    //Descricao = "Cartão Crédito"
                },
               /* new PaymentMechanism()
                {
                    Id = "3",
                    FomaPagamento = "CH",
                    Descricao = "Cheque Bancário"
                },
                new PaymentMechanism()
                {
                    Id = "4",
                    FomaPagamento = "CI",
                    Descricao = "Crédito Documentário Internacional"
                },
                new PaymentMechanism()
                {
                    Id = "5",
                    FomaPagamento = "CO",
                    Descricao = "Cheque ou Cartão Oferta"
                },
                new PaymentMechanism()
                {
                    Id = "6",
                    FomaPagamento = "CS",
                    Descricao = "Compensação de saldos em conta corrente"
                },
                new PaymentMechanism()
                {
                    Id = "7",
                    FomaPagamento = "DE",
                    Descricao = "Dinheiro Electronico"
                },
                new PaymentMechanism()
                {
                    Id = "8",
                    FomaPagamento = "MB",
                    Descricao = "Preferências de pagamento para Multicaixa"
                },*/
               /* new PaymentMechanism()
                {
                    Id = "11",
                    FomaPagamento = "PB",
                    Descricao = "Permuta de Bens"
                },*/
                new PaymentMechanism()
                {
                    Id = "TB",
                   // FormaPagamento = "TB",
                    Descricao = "Transferência Bancária"
                },
                new PaymentMechanism()
                {
                    Id = "OU",
                  //  FormaPagamento = "OU",
                    Descricao = "Outros meios aqui não assinalados"
                },
                new PaymentMechanism()
                {
                    Id = "CD",
                  //  FormaPagamento = "CD",
                    Descricao = "Venda Crédito",
                   // Descricao = "Cartão Débito" // Para Faturas
                },
            };
        }

        public static List<ProductType> getTipoProduto()
        {
            return new List<ProductType>()
            {
                new ProductType()
                {
                    Id = 1,
                    Tipo = "P",
                    Descricao = "Produto"
                },
                new ProductType()
                {
                    Id = 2,
                    Tipo = "S",
                    Descricao = "Serviço"
                },
                new ProductType()
                {
                    Id = 3,
                    Tipo = "O",
                    Descricao = "Outros"
                },
            };
        }

        public static List<BaseUnit> getUnidade()
        {
            return new List<BaseUnit>()
            {
                new BaseUnit()
                {
                    Id = 1,
                    Simbolo = "UN",
                    Unidade = "Unidade"
                },
                new BaseUnit()
                {
                    Id = 2,
                    Simbolo = "KG",
                    Unidade = "Kilograma"
                },
                new BaseUnit()
                {
                    Id = 3,
                    Simbolo = "G",
                    Unidade = "Grama"
                },
                new BaseUnit()
                {
                    Id = 4,
                    Simbolo = "L",
                    Unidade = "Litro"
                }
            };
        }

        public static List<Country> getCountry()
        {
            return new List<Country>()
            {
                new Country()
                {
                    Id = 1,
                    Pais = "Angola",
                    Sigla = "AO"
                }
            };
        }

        public static List<City> getCity()
        {
            return new List<City>()
            {
                new City()
                {
                    Id = 1,
                    Cidade = "Luanda",
                    PaisId = 1
                }
            };
        }

        public static Category getCagory()
        {
            return new Category()
            {
                Id = 1,
                Categoria = "Geral",
            };
        }

        public static CurrentAccountSystem getCurrentAccount()
        {
            return new CurrentAccountSystem()
            {
                Id = 1,
                Descricao = "Caixa Geral",
                FlagState = true,
                Saldo = 0,
                SaldoAbertura = 0,
            };
        }

        public static List<ConfigCurrentAccount> getConfigCurrentAccount()
        {
            return new List<ConfigCurrentAccount>() {
                new ConfigCurrentAccount(){
                    Id = 1,
                    CurrentAccountId = 1,
                    PaymentMechanismId = "NU", // Numerário
                },
                new ConfigCurrentAccount()
                {
                    Id = 2,
                    CurrentAccountId = 1,
                    PaymentMechanismId = "NU", 
                },
                new ConfigCurrentAccount()
                {
                    Id = 3,
                    CurrentAccountId = 1,
                    PaymentMechanismId = "CC", 
                },
                new ConfigCurrentAccount()
                {
                    Id = 4,
                    CurrentAccountId = 1,
                    PaymentMechanismId = "OU", 
                },
                new ConfigCurrentAccount()
                {
                    Id = 5,
                    CurrentAccountId = 1,
                    PaymentMechanismId = "TB", 
                }
            };
        }

        public static List<MovmentType> getMovmentsType()
        {
            return new List<MovmentType>()
            {
                new MovmentType()
                {
                    Id = "1",
                    TipoMovimento = "Transfeência"
                },
                new MovmentType()
                {
                    Id = "2",
                    TipoMovimento = "Deposito"
                },
                new MovmentType()
                {
                    Id = "3",
                    TipoMovimento = "Pagamento"
                },
            };
        }

        public static Customer getFinalCustimer(){
            return new Customer()
            {
                Id = 1,
                Cliente = "Consumidor Final",
                Conta_Corrente = "1123043",
                CidadeId = 1,
                Nif = "999999999",
                DataNascimento = Convert.ToDateTime("1997-01-01"),
            };
        }
        //
    }
}
