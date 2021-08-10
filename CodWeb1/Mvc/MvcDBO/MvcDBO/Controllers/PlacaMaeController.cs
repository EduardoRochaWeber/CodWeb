using MvcDBO.Models;
using MvcDBO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDBO.Controllers
{
    public class PlacaMaeController : BaseController<PlacaMae, PlacaMaeRepository>
    {
        public PlacaMaeController() : base(new PlacaMaeRepository())
        {

        }
        //PlacaMaeRepository repository = new PlacaMaeRepository();

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
        //public ActionResult Create(PlacaMae model)
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
        //public ActionResult Edit(PlacaMae model)
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