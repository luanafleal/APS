using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LuanaFerreira.Models
{
    public class Item
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        public int Percentual { get; set; }
        public int Quantidade { get; set; }
    }
}