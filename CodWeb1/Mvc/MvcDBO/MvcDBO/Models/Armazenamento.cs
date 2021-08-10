using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDBO.Models
{
    public class Armazenamento : BaseModel
    {
        [Display(Name = "Tipo de Armazenamento")]
        public string TipoArmazenamento { get; set; }
        public string Medidas { get; set; }
        [Display(Name = "Tipo de Barramento")]
        public string TipoBarramento { get; set; }
        [Display(Name = "Tamanho de Armazenamento")]
        public int TamanhoArmazenamento { get; set; }
    }
}