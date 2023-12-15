using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LuanaFerreira.Models;

namespace LuanaFerreira.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
       {
       }
        public DbSet<Item> Item {get; set;}
        public DbSet<LuanaFerreira.Models.Marca> Marca { get; set; }
        public DbSet<LuanaFerreira.Models.Produto> Produto { get; set; }
        public DbSet<NotaDeVenda> NotasDeVendas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Transportadora> Transportadoras { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }    
        public DbSet<TipoDePagamento> TiposDePagamentos { get; set; }    
        public DbSet<PagamentoComCheque> PagamentoComCheques { get; set; }    
        public DbSet<PagamentoComCartao> PagamentoComCartões { get; set; }    
        
    }
}