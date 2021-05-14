using System;
using Domain.Domain.Entities.ProductStock;
using Domain.Domain.Interfaces.Repositories.ProductStock;
using System.Linq;

namespace Infrastructure.Data.Repositories.ProductStock
{
    public class StockRepository : BaseRepository<Stock>, IStockRepository
    {
        public object view1(string search, int companyTypeId)
        {
            search = search.ToLower();
            return (from item in _contextDB.Stock.Where(c => c.Id.ToString().Contains(search) && c.Produto.FlagState && companyTypeId == 2 ? c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true)
                    select new { item.Id, Artigo = item.Produto.Descricao,item.Armazem.Armazem,
                        item.MinStock, item.MaxStock, item.Quantidade, item.DataCadastro }).ToList();
        }

        public object view2(string search, int companyTypeId)
        {
            search = search.ToLower();
            return (from item in _contextDB.Stock.Where(c => c.Id.ToString().Contains(search) && c.Produto.FlagState && companyTypeId == 2 ? c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true)
                    select new {
                        item.Id,
                        Artigo = item.Produto.Descricao,
                        item.Armazem.Armazem,
                        item.MinStock,
                        item.MaxStock,
                        
                        item.Quantidade,
                    }).ToList();
        }

        public Stock getStockArmazemProduct(int idProduct, int idStorage, int companyTypeId)
        {
            if (idStorage != 0)
                return _contextDB.Stock.Where(c => c.ProdutoId == idProduct && c.ArmazemId == idStorage).FirstOrDefault();//&& c.Produto.FlagState && companyTypeId == 2 ? c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true).FirstOrDefault();
             return _contextDB.Stock.Where(c => c.ProdutoId == idProduct && c.Produto.FlagState).FirstOrDefault();
            }
        

        public object viewProductStockArmazem(int idArmazem, int companyTypeId)
        {

            // se o id do Armazem for zero retorna torna todos os produtos com todos armazens
            
            if(idArmazem != 0)
                return (from item in _contextDB.Stock.Where(c => c.ArmazemId == idArmazem && c.Produto.FlagState && companyTypeId == 2 ? c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true)
                        select new
                        {
                            item.Produto.Id,
                            Id_Stock = item.Id,
                            item.Armazem.Armazem,
                            item.Produto.Descricao,
                            item.Produto.Categoria.Categoria,
                            item.Produto.Preco1,
                            Taxa = item.Produto.CodigoTaxa.Taxa,
                            Stock = item.Quantidade,
                            item.MinStock,
                        }).ToList();
            else
                return (from item in _contextDB.Stock.Where(c => c.Produto.FlagState && companyTypeId == 2 ?  c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true)
                        select new
                        {
                            item.Produto.Id,
                            Id_Stock = item.Id,
                            item.Armazem.Armazem,
                            item.Produto.Descricao,
                            item.Produto.Categoria.Categoria,
                            item.Produto.Preco1,
                            Taxa = item.Produto.CodigoTaxa.Taxa,
                            Stock = item.Quantidade,
                            item.MinStock,
                        }).ToList();

            
        }

        public object viewProductStockArmazemProduct(int idArmazem, string search, int companyTypeId)
        {

            // se o id do Armazem for zero retorna torna todos os produtos com todos armazens

            if (idArmazem != 0)
                return (from item in _contextDB.Stock.Where(c => (c.ArmazemId == idArmazem) && (c.Produto.Descricao.Contains(search) && c.Produto.FlagState) && (companyTypeId == 2 ? c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true))
                        select new
                        {
                            item.Produto.Id,
                            Id_Stock = item.Id,
                            stock = item.Armazem.Armazem,
                            item.Produto.Descricao,

                            item.Produto.Preco1,
                            Preco1CIVA = item.Produto.Preco1 * (item.Produto.CodigoTaxa.Taxa / 100 + 1),
                            Taxa = item.Produto.CodigoTaxa.Taxa,
                            Stock = item.Quantidade,
                            item.MinStock,
                            Category = item.Produto.Categoria.Categoria,
                            tipo_artigo = item.Produto.TipoArtigo.Descricao

                        }).ToList();
            else
                return (from item in _contextDB.Stock.Where(c => c.Produto.FlagState && c.Produto.Descricao.Contains(search) && (companyTypeId == 2 ? c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true))
                        select new
                        {
                            item.Produto.Id,
                            Id_Stock = item.Id,
                            stock = item.Armazem.Armazem,
                            item.Produto.Descricao,

                            item.Produto.Preco1,
                            Preco1CIVA = item.Produto.Preco1 * (item.Produto.CodigoTaxa.Taxa/100 + 1),
                            Taxa = item.Produto.CodigoTaxa.Taxa,
                            Stock = item.Quantidade,
                            item.MinStock,
                            Category = item.Produto.Categoria.Categoria,
                            tipo_artigo = item.Produto.TipoArtigo.Descricao,
                            Data = item.Produto.DataExpiracao

                        }).ToList();


        }

        public object viewProductStockArmazemForEntryAndRetreat(int idArmazem, int companyTypeId)
        {
            // se o id do Armazem for zero retorna torna todos os produtos com todos armazens
            if (idArmazem != 0)
                return (from item in _contextDB.Stock.Where(c => c.ArmazemId == idArmazem && c.Produto.FlagState)// && companyTypeId == 2 ? c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true)
                        select new
                        {
                            item.Produto.Id,
                            item.Produto.Descricao,
                            item.Produto.Categoria.Categoria,
                            Taxa = item.Produto.CodigoTaxa.Taxa,
                            Stock = item.Quantidade,
                            item.MinStock,
                        }).ToList();
            else
                return (from item in _contextDB.Stock.Where(c => c.Produto.FlagState)// && companyTypeId == 2 ? c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true)
                        select new
                        {
                            item.Produto.Id,
                            item.Produto.Descricao,
                            item.Produto.Categoria.Categoria,
                            Taxa = item.Produto.CodigoTaxa.Taxa,
                            Stock = item.Quantidade,
                            item.MinStock,
                        }).ToList();
        }

        public object viewProductStockArmazem2(int idArmazem, int companyTypeId)
        {
            if(idArmazem != 0)
                return (from item in _contextDB.Stock.Where(c => c.ArmazemId == idArmazem && c.Produto.FlagState && companyTypeId == 2 ? c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true)
                        select new
                        {
                            item.Armazem.Armazem,
                            item.Produto.Codigo,
                            item.Produto.Codigo_Barra,
                            item.Produto.Descricao,
                            item.Produto.Preco1,
                            Stock = item.Quantidade,
                            item.MinStock,
                            item.MaxStock,
                            Iva = item.Produto.CodigoTaxa.Taxa,
                            Taxa = item.Produto.CodigoTaxa.Taxa,
                        }).ToList();
            else

                return (from item in _contextDB.Stock.Where(c => c.Produto.FlagState && companyTypeId == 2 ? c.Produto.MotivoISE.RegimeSimplificado : companyTypeId == 3 ? c.Produto.MotivoISE.RegimeExclusao : true)
                        select new
                        {
                            item.Armazem.Armazem,
                            item.Produto.Codigo,
                            item.Produto.Codigo_Barra,
                            item.Produto.Descricao,
                            item.Produto.Preco1,
                            Stock = item.Quantidade,
                            item.MinStock,
                            item.MaxStock,
                            Iva = item.Produto.CodigoTaxa.Taxa,
                            Taxa = item.Produto.CodigoTaxa.Taxa,
                        }).ToList();
        }

    }
}
