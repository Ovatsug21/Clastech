using ClasTech.Teste.Business.Entities;
using ClasTech.Teste.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasTech.Teste.Service
{
    public class PedidoService
    {
        public IList<PedidoViewModel> GetPedidosAtivos()
        {
            try
            {
                using (var db = new clastechTesteEntities())
                {
                    var list = (from t in db.pedido
                                where( t.ativo == true)
                                select new PedidoViewModel
                                {
                                    Id = t.id,
                                    Nome = t.nome,
                                    Descricao = t.descricao,
                                    ValorTotal = t.valorTotal,
                                    DataPedido = t.dataPedido,
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

        public IList<PedidoViewModel> GetPedidosAno()
        {
            try
            {
                using (var db = new clastechTesteEntities())
                {
                    var list = (from t in db.pedido
                                where (t.dataPedido.Year == 2017)
                                select new PedidoViewModel
                                {
                                    Id = t.id,
                                    Nome = t.nome,
                                    Descricao = t.descricao,
                                    ValorTotal = t.valorTotal,
                                    DataPedido = t.dataPedido,
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

        public IList<PedidoViewModel> GetPedidoMaiorValor()
        {
            try
            {
                using (var db = new clastechTesteEntities())
                {
                    var list = (from t in db.pedido
                                // where ( max t.valorTotal )
                                select new PedidoViewModel
                                {
                                    Id = t.id,
                                    Nome = t.nome,
                                    Descricao = t.descricao,
                                    ValorTotal = t.valorTotal,
                                    DataPedido = t.dataPedido,
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