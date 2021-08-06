using AnimeListMvc.Models;
using AnimeListMvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeListMvc.Controllers
{
    public class AnimesController : BaseController<Animes, AnimesRepository>
    {
        public AnimesController():base(new AnimesRepository())
        {

        }
    }
}