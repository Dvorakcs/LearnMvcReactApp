using LearnMvcReactApp.Server.Dados;
using LearnMvcReactApp.Server.Models;
using LearnMvcReactApp.Server.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace LearnMvcReactApp.Server.Repositories
{
    public class ProdutosRepository : GenericsRepository<Produtos>, IProdutosRepository
    {
        
        public ProdutosRepository(MyDbContext context) : base(context)
        {
        }
    }
}
