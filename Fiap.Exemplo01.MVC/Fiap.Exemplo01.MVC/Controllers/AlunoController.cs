using Fiap.Exemplo01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        //Action para abrir o formulário
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        //Action para cadastrar as informações do formulário
        [HttpPost]
        public ActionResult Salvar(Aluno aluno)
        {
            //Viewbag não é mantido após o redirect
            ViewBag.nomeAluno = aluno.Nome;
            ViewBag.dataAluno = aluno.DataNascimento;
            ViewBag.salarioAluno = aluno.Salario;

            //Tempdata é mantido após o redirect
            TempData["mensagem"] = "Aluno Registrado!";
            return View(aluno);
            //return Content("Gravou!" + aluno.Nome + " - " + aluno.DataNascimento.ToString("dd/MM/yyyy") + " - " + aluno.Salario); //Texto
        }
    }
}