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
    public class PedidoItemController : ApiController
    {
        private readonly PedidoItemService _pedidoItemService;

        public PedidoItemController()
        {
            _pedidoItemService = new PedidoItemService();
        }

        [HttpPost]
        public IList<PedidoItemViewModel> GetPedidoItemValor()
        {
            return _pedidoItemService.GetPedidoItemValor();
        }

        [HttpPost]
        public IList<PedidoItemViewModel> GetPedidoItemNome()
        {
            return _pedidoItemService.GetPedidoItemNome();
        }
    }
}