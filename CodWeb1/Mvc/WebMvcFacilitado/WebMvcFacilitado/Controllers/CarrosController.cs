using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvcFacilitado.Models;
using WebMvcFacilitado.Repository;

namespace WebMvcFacilitado.Controllers
{
    public class CarrosController : BaseController<Carros, CarrosRepository>
    {
        public CarrosController(): base(new CarrosRepository())
        {

        }
    }
}