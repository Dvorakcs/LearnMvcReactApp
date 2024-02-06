using LearnMvcReactApp.Server.Dados;
using LearnMvcReactApp.Server.Models;
using LearnMvcReactApp.Server.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace LearnMvcReactApp.Server.Repositories
{
    public class UsuariosRepository : GenericsRepository<Usuarios>, IUsuariosRepository
    {
        
        public UsuariosRepository(MyDbContext context) : base(context)
        {
        }
    }
}
