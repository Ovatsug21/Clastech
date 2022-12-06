using ClasTech.Teste.Business.Entities;
using ClasTech.Teste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasTech.Teste.Service
{
    public class PedidoItemService
    {
        public IList<PedidoItemViewModel> GetPedidoItemValor()
        {
            try
            {
                using (var db = new clastechTesteEntities())
                {
                    var list = (from t in db.pedidoItem
                                where (t.valor < ((decimal)(18.50)) )
                                select new PedidoItemViewModel
                                {
                                    Id = t.id,
                                    ProdutoId = t.produtoId,
                                    Nome = t.nome,
                                    Descricao = t.descricao,
                                    Valor = t.valor,
                                    Ativo = t.ativo
                                }).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<PedidoItemViewModel> GetPedidoItemNome()
        {
            try
            {
                using (var db = new clastechTesteEntities())
                {
                    var list = (from t in db.pedidoItem
                                where (t.nome.Contains("arroz"))
                                select new PedidoItemViewModel
                                {
                                    Id = t.id,
                                    ProdutoId = t.produtoId,
                                    Nome = t.nome,
                                    Descricao = t.descricao,
                                    Valor = t.valor,
                                    Ativo = t.ativo
                                }).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
