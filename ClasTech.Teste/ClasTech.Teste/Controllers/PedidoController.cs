using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClasTech.Teste.Models;
using ClasTech.Teste.Service;

namespace ClasTech.Teste.Controllers
{
    public class PedidoController : ApiController
    {
        private readonly PedidoService _pedidoService;

        public PedidoController()
        {
            _pedidoService = new PedidoService();
        }

        [HttpPost]
        public IList<PedidoViewModel> GetPedidosAtivos()
        {
            return _pedidoService.GetPedidosAtivos();
        }

        [HttpPost]
        public IList<PedidoViewModel> GetPedidosAno()
        {
            return _pedidoService.GetPedidosAno();
        }

        [HttpPost]
        public IList<PedidoViewModel> GetPedidoMaiorValor()
        {
            return _pedidoService.GetPedidoMaiorValor();
        }
    }
}