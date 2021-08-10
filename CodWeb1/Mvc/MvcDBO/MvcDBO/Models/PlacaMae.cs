using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDBO.Models
{
    public class PlacaMae : BaseModel
    {
        [Display(Name = "Tipo de Slot para Memória RAM")]
        public string TipoBarramentoMemoriaRam { get; set; }

        [Display(Name = "Quantidade de Slots para Memória RAM")]
        public int QtBarramentoMemoriaRam { get; set; }
        [Display(Name = "Tipo de Barramento para Armazenamento")]
        public string TipoBarramentoArmazenamento { get; set; }

        [Display(Name = "Quantidade de Slots para Armazenamento")]
        public int QtBarramentoArmazenamento { get; set; }
        public string Soquete { get; set; }
        public string Chipset { get; set; }
    }
}