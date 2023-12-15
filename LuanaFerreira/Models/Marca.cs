using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuanaFerreira.Models
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public ICollection<Produto>? Produtos { get; } = new List<Produto>();
    }
}