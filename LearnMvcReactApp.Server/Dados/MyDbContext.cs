using LearnMvcReactApp.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnMvcReactApp.Server.Dados
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {

        }

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
