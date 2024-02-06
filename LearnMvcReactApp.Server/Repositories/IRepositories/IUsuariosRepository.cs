using LearnMvcReactApp.Server.Models;

namespace LearnMvcReactApp.Server.Repositories.IRepositories
{
    public interface IUsuariosRepository:IGenericsRepository<Usuarios>
    {
        Task<Usuarios> GetByName(string Nome);
    }
}
