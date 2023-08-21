using Microsoft.EntityFrameworkCore;
using BakeryStock.Models;

namespace BakeryStock.Data
{
    public class BakeryStockContext : DbContext
    {
        public BakeryStockContext(DbContextOptions <BakeryStockContext> options) : base(options) { }

        public DbSet<Produto>? Produtos { get; set; }

        public DbSet<ProdutoTabela>? ProdutoTabelas { get; set;}

        public DbSet<Registro>? Registros { get; set; }

        public DbSet<Tabela>? Tabelas { get; set;}
    }
}
