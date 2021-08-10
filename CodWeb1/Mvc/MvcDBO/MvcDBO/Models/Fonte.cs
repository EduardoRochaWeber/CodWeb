using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDBO.Models
{
    public class Fonte : BaseModel
    {
        [Display(Name = "Potência" )]
        public int QtW { get; set; }
        public string Modulariade { get; set; }
    }
}