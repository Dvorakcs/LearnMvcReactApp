using LearnMvcReactApp.Server.Models;
using LearnMvcReactApp.Server.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace LearnMvcReactApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : GenericController<Usuarios>
    {
        public UsuariosController(IGenericsRepository<Usuarios> repository) : base(repository)
        {
        }

        protected override int GetEntityId(Usuarios entity)
        {
            throw new NotImplementedException();
        }

        protected override void UpdateEntity(Usuarios existingEntity, Usuarios newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
