using LearnMvcReactApp.Server.Models;
using LearnMvcReactApp.Server.Repositories;
using LearnMvcReactApp.Server.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace LearnMvcReactApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : GenericController<Usuarios, IUsuariosRepository>
    {
        private readonly IUsuariosRepository _usuarioRepository;

        public UsuariosController(IUsuariosRepository usuariosRepository)
            : base(usuariosRepository)
        {
            _usuarioRepository = usuariosRepository;
        }
        protected override int GetEntityId(Usuarios entity)
        {
            throw new NotImplementedException();
        }

        protected override void UpdateEntity(Usuarios existingEntity, Usuarios newEntity)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("login/")]
        public async Task<ActionResult<Usuarios>> Login([FromBody] Usuarios usuario)
        {
            var usuarioDb = await _usuarioRepository.GetByName(usuario.Nome);

            return Ok(usuarioDb);
        }
    }
}
