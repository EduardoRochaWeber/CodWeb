using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvcFacilitado.Models
{
    public class Automovel : BaseModel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Cilindradas { get; set; }
    }
}