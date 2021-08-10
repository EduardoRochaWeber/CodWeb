using MvcDBO.Models;
using MvcDBO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDBO.Controllers
{
    public class ProcessadorController : BaseController<Processador, ProcessadorRepository>
    {
        public ProcessadorController() : base(new ProcessadorRepository())
        {

        }
        //ProcessadorRepository repository = new ProcessadorRepository();

        //public ActionResult Index()
        //{
        //    return View();
        //}
        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Create(Processador model)
        //{
        //    repository.Create(model);
        //    return RedirectToAction("Create");
        //}
        //public ActionResult List()
        //{
        //    return View(repository.Read());
        //}
        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    return View(repository.Read(id));
        //}
        //[HttpPost]
        //public ActionResult Edit(Processador model)
        //{
        //    repository.Update(model);
        //    return RedirectToAction("List");
        //}
        //public ActionResult Delete(int id)
        //{
        //    repository.Delete(id);
        //    return RedirectToAction("List");
        //}
        //public ActionResult Details(int id)
        //{
        //    return View(repository.Read(id));
        //}
    }
}