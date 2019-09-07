using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewData["Nome"] = "Emillyn";
            //ViewData["Email"] = "emillyn_muniz@hotmail.com";
            //ViewData["Curso"] = "ASP .NET MVC";
            //ViewData["DataInicio"] = new DateTime(2019, 09, 06);

            //ViewBag.Nome = "Emillyn";
            //ViewBag.Email = "emillyn_muniz@hotmail.com";
            //ViewBag.Curso = "ASP .NET MVC";
            //ViewBag.DataInicio = new DateTime(2019, 09, 06);

            ViewBag.paises = new List<string>{
                "Brasil",
                "Jamaica",
                "EUA",
                "Canada",
                "Portugal"
            };

            return View();
        }

        public string Inicio()
        {
            return "Minha primeira aplicação Asp.net MVC";
        }

        public string Saudacao(int id)
        {
            return "Codigo recebido da url = " + id.ToString();
        }

    }
}