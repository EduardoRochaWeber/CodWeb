using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDBO.Models
{
    public class Gabinete : BaseModel
    {
        [Display(Name = "Tamanhos de Placas Mãe Suportados")]
        public string TamanhosSuportadosPlacaMae { get; set; }
        public string Tamanho { get; set; }
        public string Medidas { get; set; }
    }
}