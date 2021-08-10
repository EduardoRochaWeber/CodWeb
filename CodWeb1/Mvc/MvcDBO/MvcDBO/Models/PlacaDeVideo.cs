using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDBO.Models
{
    public class PlacaDeVideo : BaseModel
    {
        [Display(Name = "Frequência Base")]
        public decimal FrequenciaBase { get; set; }
        [Display(Name = "Frequência Máxima")]
        public decimal FrequenciaMax { get; set; }
        public int Litografia { get; set; }
    }
}