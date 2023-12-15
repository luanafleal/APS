using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuanaFerreira.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        public string? NomeDoCartao {get; set; }
        public string? Bandeira {get; set; }
    }
}