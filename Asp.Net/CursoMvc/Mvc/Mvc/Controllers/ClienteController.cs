using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        // GET: Cliente
        public ActionResult Detalhe()
        {
            //logica de acesso aos dados usando entidades
            Cliente cliente = new Cliente()
            {
                ClientId = 200,
                Nome = "Emillyn",
                Email = "emillyn_muniz@hotmail.com",
                Telefone = "154545454"
            };

            return View(cliente);
        }
        
        [HttpPost]    
        public ActionResult SalvarCliente(Cliente cliente)
        {
            //implementar a logica para salvar

            return View(cliente);
        }
    }
}