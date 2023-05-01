using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFitBasic.Models
{
    public class Ciclista
    {
        [Key]
        public int id { get; set; }

        [Required, MaxLength(100)]
        public string? Nome { get; set;}
        public DateTime Data { get; set;}
        public int MedidaCavalo { get; set; }
        public int MedidaAntebraco { get; set;}
        public int NivelFlexibilidade { get; set; }
    }
}
