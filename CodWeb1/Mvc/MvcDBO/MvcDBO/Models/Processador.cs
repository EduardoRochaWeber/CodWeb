using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDBO.Models
{
    public class Processador : BaseModel
    {
        [Display(Name = "Quantidade de Núcleos" )]
        public int QtNucleos { get; set; }

        [Display(Name = "Quantidade de Threads")]
        public int QtThreads { get; set; }
        [Display(Name = "Frequência Base")]
        public decimal FrequenciaBase { get; set; }
        [Display(Name = "Frequência Máxima")]
        public decimal FrequenciaMax { get; set; }
        public int Litografia { get; set; }
        public string Soquete { get; set; }    
    }
}