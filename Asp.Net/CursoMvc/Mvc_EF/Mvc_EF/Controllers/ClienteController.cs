using Mvc_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_EF.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {

            //libera o recurso quando terminar de usar
            using (ClienteContext clienteContext = new ClienteContext()) {

                List<Cliente> clientes = clienteContext.clientes.ToList();
                return View(clientes);
            } ;
            
        }

        public ActionResult Detalhes(int id)
        {
            using (ClienteContext clienteContext = new ClienteContext())
            {

                Cliente clientes = clienteContext.clientes.Single(cli => cli.ClienteId == id);
                return View(clientes);
            };
        }
    }
}