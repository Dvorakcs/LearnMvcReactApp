using LearnMvcReactApp.Server.Dados;
using LearnMvcReactApp.Server.Models;
using LearnMvcReactApp.Server.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace LearnMvcReactApp.Server.Repositories
{
    public class UsuariosRepository : GenericsRepository<Usuarios>, IUsuariosRepository
    {
        private readonly MyDbContext _dbContext;
        public UsuariosRepository(MyDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<Usuarios> GetByName(string Nome)
        {
            return await _dbContext.Usuarios.Where(usuario => usuario.Nome == Nome).FirstOrDefaultAsync();
        }
    }
}
