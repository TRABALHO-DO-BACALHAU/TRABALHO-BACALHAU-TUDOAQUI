using ProjetoIntegrador5.Dao;
using ProjetoIntegrador5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrador5.Controllers
{
    public class CompromissoController:Controller
    {
        public ActionResult Index()
        {
            var Compromissos = new CompromissoDao().Buscar();
            return View(Compromissos);
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Compromisso CompromissoDao)
        {
            new CompromissoDao().Gravar(CompromissoDao);
            return RedirectToAction("Index");
        }
        public ActionResult Detalhe(int id)
        {
            Compromisso Compromisso = new CompromissoDao().Buscar(id);
            return View(Compromisso);
        }

        public ActionResult Editar(int id)
        {
            var Compromisso = new CompromissoDao().Buscar(id);
            return View(Compromisso);
        }
        [HttpPost]
        public ActionResult Editar(Compromisso objCompromisso)
        {
            new CompromissoDao().Alterar(objCompromisso);
            return RedirectToAction("Index", "Compromisso");
        }


        public ActionResult Excluir(int id)
        {
            new CompromissoDao().Excluir(id);
            return RedirectToAction("Index");

        }
    }
}

    