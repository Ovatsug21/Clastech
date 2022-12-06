using ClasTech.Teste.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClasTech.Teste.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pedidoItemService = new PedidoItemService();
            var pedidoService = new PedidoService();

            var listaPedido = pedidoService.GetPedidosAno();
            var ListaPedidoItem = pedidoItemService.GetPedidoItemValor();

            ViewBag.ListaPedido = listaPedido;
            ViewBag.ListaPedidoitem = ListaPedidoItem;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}