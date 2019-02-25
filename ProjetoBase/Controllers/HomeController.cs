using ProjetoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBase.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var aluno = RetornarAlunos().First();

            return View(aluno);
        }
        public ActionResult Inserir()
        {
            return View();

        }
        public ActionResult ListarAlunos()
        {
            return View(RetornarAlunos().ToList());

        }

        public IQueryable<Aluno> RetornarAlunos()
        {
            var alunosLista = new List<Aluno>
            {
                new Aluno
                {
                    Nome = "teste 01",
                    Idade = 10
                },
                new Aluno
                {
                    Nome ="teste 02",
                    Idade = 11
                }, new Aluno
                {
                    Nome = "teste 03",
                    Idade = 12
                }
            };
            return alunosLista.AsQueryable();

        }

        [HttpPost]
        public ActionResult Inserir(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", aluno);
            }
            return View(aluno);

        }

        public ActionResult RelacaoAlunos()
        {

            return View();
        }

        public ActionResult RelacaoAlunosAjax()
        {
            return View();
        }
        public PartialViewResult ListarAlunosAjax()
        {
            Thread.Sleep(2000);
            return PartialView("_ResultadoAlunos", RetornarAlunos().ToList());
        }
        
        public ActionResult InserirAjax()
        {
            return View();

        }
        public PartialViewResult InserirAlunoAjax(Aluno aluno)
        {
            Thread.Sleep(2000);
            return PartialView("_ResultadoInsercaoAjax",aluno);
        }
        public ActionResult RetornarDados()
        {
            ViewData["nomeCurso"]= "ASP.NET MVC"; //ciclo de vida: uma requisição
            TempData["nomeCurso"]= "ASP.NET MVC"; //ciclo de vida: duas requisição
            ViewBag.nomeCurso = "ASP.NET MVC"; //ciclo de vida: atribuido dinamicamente

            return View();
        }



    }
}