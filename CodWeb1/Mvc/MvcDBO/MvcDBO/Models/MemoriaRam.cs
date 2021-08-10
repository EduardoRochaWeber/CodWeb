using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDBO.Models
{
    public class MemoriaRam : BaseModel
    {
        [Display(Name = "Tamanho das Memórias")]
        public int TamanhoMemoria { get; set; }
        [Display(Name = "Frequência")]
        public int Frequencia { get; set; }
        public string Barramento { get; set; }
    }
}