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
        //Exibi a lista de alunos
        public ActionResult Index()
        {
            //criei uma instancia da classe AlunoBLL
            AlunoBLL _aluno = new AlunoBLL();

            //estou usando o metodo getAlunos e retornando uma lista de alunos
            List<Aluno> alunos = _aluno.GetAlunos().ToList();

            return View(alunos);
        }

        //Get
        //Apresenta o formulario que ira inserir os dados
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }


        //Ira receber usando Model Binding
        [HttpPost]
        [ActionName("Create")]//Definindo o nome da Action que sera tratada
        public ActionResult Create_Post(Aluno aluno)
        {
            // criando uma nova instancia
            //Aluno aluno = new Aluno();
            //UpdateModel(aluno) ou TryUpdateModel(aluno)


            //Passando o FormCollection como parametros
            //aluno.Nome = formulario["Nome"];
            //aluno.Email = formulario["Email"];
            //aluno.Idade = Convert.ToInt32(formulario["Idade"]);
            //aluno.DataIncricao = Convert.ToDateTime(formulario["DataIncricao"]);
            //aluno.Sexo = formulario["Sexo"];

            //Usando o metodo Postado atraves do Model Binding (BLL)
            //Passando como Paramentro Aluno 

            //mais recomendado
            if (ModelState.IsValid)
            {
                AlunoBLL alunoLL = new AlunoBLL();
                alunoLL.IncluirAluno(aluno);
                return RedirectToAction("Index");
            }

            return View();
            
        }

        //Get
        //Mostra os dados do Aluno
        public ActionResult Edit(int id)
        {
            AlunoBLL alunobll = new AlunoBLL();
            Aluno aluno = alunobll.GetAlunos().Single(x => x.Id == id);

            return View(aluno);
        }


        //Metodo que Altera o Aluno no banco de dados
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post([Bind(Exclude = "Nome")]Aluno aluno)
        {
            //Protegendo e controlando os Updates indesejaveis com Fiddler 
            AlunoBLL alunobll = new AlunoBLL();
            aluno.Nome = alunobll.GetAlunos().Single(x => x.Id == aluno.Id).Nome; //Pegando o Nome do Banco 

            //passando como parametros o id
            //Aluno aluno = alunobll.GetAlunos().Single(x => x.Id == id);
            //UpdateModel(aluno, includeProperties: new[] { "id", "Email", "Idade", "DataIncricao", "Sexo" });
            //UpdateModel(aluno, null, null, excludeProperties: new[] { "Nome" }); 


            if (ModelState.IsValid)
            {
                alunobll.AtualizarAluno(aluno);
                return RedirectToAction("Index");
            }

            return View(aluno);
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            AlunoBLL alunobll = new AlunoBLL();
            alunobll.DeletarAluno(id);
            return RedirectToAction("Index");
        }


        ////Deletando Aluno 
        //[HttpPost]
        //public ActionResult Delete(Aluno aluno)
        //{
           
        //    if (ModelState.IsValid)
        //    {
        //        AlunoBLL alunobll = new AlunoBLL();
        //        alunobll.DeletarAluno(aluno.Id);
        //        return RedirectToAction("Index");
        //    }

        //    return View(aluno);
        //}

        public ActionResult Details(int id)
        {
            AlunoBLL alunobll = new AlunoBLL();
            Aluno aluno = alunobll.GetAlunos().Single(x => x.Id == id);

            return View(aluno);
        }

        public ActionResult Procurar(string procurarPor, string criterio)
        {
            AlunoBLL alunobll = new AlunoBLL();
            if(procurarPor == "Email")
            {

                Aluno aluno = alunobll.GetAlunos().SingleOrDefault(x => x.Email == criterio || criterio == null);
                return View(aluno);
            }
            else
            {
               Aluno aluno = alunobll.GetAlunos().SingleOrDefault(x => x.Nome == criterio || criterio == null);
                return View(aluno);
            }
        }

    }
}