using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuanaFerreira.Models
{
    public class TipoDePagamento
    {
        [Key]
        public int Id { get; set; }
        public string? NomeDoCobrado { get; set; }
        public string? InformacoesAdicionais { get; set; }

        
    }
}