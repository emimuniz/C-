using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace Mvc_BObjects.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //criei uma instancia da classe AlunoBLL
            AlunoBLL _aluno = new AlunoBLL();

            //estou usando o metodo getAlunos e retornando uma lista de alunos
            List<Aluno> alunos = _aluno.GetAlunos().ToList();

            return View(alunos);
        }
    }
}