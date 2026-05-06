using Microsoft.EntityFrameworkCore;
using MinhaEstante.Models;

namespace MinhaEstante.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
