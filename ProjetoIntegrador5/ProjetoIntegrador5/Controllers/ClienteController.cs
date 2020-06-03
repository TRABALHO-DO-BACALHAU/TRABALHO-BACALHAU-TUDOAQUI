using ProjetoIntegrador5.Dao;
using ProjetoIntegrador5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrador5.Controllers
{
    public class ClienteController: Controller
    {

        public ActionResult Index()
        {
            var clientes = new ClienteDao().Buscar();
            return View(clientes);
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Cliente ClienteDao)
        {
            new ClienteDao().Gravar(ClienteDao);
            return RedirectToAction("Index");
        }
        public ActionResult Detalhe(int id)
        {
            Cliente cliente = new ClienteDao().Buscar(id);
            return View(cliente);
        }

        public ActionResult Editar(int id)
        {
            var Cliente = new ClienteDao().Buscar(id);
            return View(Cliente);
        }
        [HttpPost]
        public ActionResult Editar(Cliente objCliente)
        {
            new ClienteDao().Alterar(objCliente);
            return RedirectToAction("Index", "Cliente");
        }


        public ActionResult Excluir(int id)
        {
            new ClienteDao().Excluir(id);
            return RedirectToAction("Index");

        }
    }
}