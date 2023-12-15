using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuanaFerreira.Models
{
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataLimite {get; set; }
        public decimal Valor {get; set; }
        public bool Pago {get; set; }
    }
}