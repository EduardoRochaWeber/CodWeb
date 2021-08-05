using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private CarrosRepository repository = new CarrosRepository(); 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastrar()
        {
            return View();
        }
        public ActionResult Listar()
        {
            List<Carros> model = repository.Listar();
            return View(model);
        }
        [HttpPost]
        public ActionResult Salvar(Carros model)
        {
            repository.Salvar(model);
            return RedirectToAction("Cadastrar");
        }
        public ActionResult Deletar(int id)
        {
            repository.Deletar(id);
            return RedirectToAction("Listar");
        }
        /*public ActionResult Editar(int id)
        {
            repository.Deletar(id);
            return RedirectToAction("Listar");
        }*/
    }
}