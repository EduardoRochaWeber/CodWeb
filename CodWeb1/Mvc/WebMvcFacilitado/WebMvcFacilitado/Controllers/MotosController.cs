using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMvcFacilitado.Models;
using WebMvcFacilitado.Repository;

namespace WebMvcFacilitado.Controllers
{
    public class MotosController : BaseController<Motos, MotosRepository>
    {
        public MotosController(): base(new MotosRepository())
        {

        }
    }
}