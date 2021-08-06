using AnimeListMvc.Models;
using AnimeListMvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimeListMvc.Controllers
{
    public class BaseController<M, R> : Controller where M: BaseModel where R: BaseRepository<M>
    {
        R repository;
        public BaseController(R repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(M model)
        {
            repository.Create(model);
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repository.Read(id));
        }
        [HttpPost]
        public ActionResult Edit(M model)
        {
            repository.Update(model);
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            return View(repository.Read());
        }
        public ActionResult Details(int id)
        {
            return View(repository.Read(id));
        }
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("List");
        }
    }
}