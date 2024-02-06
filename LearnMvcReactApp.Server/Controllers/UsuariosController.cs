using LearnMvcReactApp.Server.Models;
using LearnMvcReactApp.Server.Repositories.IRepositories;
using LearnMvcReactApp.Server.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnMvcReactApp.Server.Controllers
{
    [Authorize]  
    [Route("api/[controller]")]
    public class UsuariosController : GenericController<Usuarios>
    {
        private readonly ITokenService _tokenService;
        public UsuariosController(IUsuariosRepository usuariosRepository, ITokenService tokenService)
            : base(usuariosRepository)
        {
            _tokenService = tokenService;
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
        [AllowAnonymous]
        [Route("login/")]
        public async Task<ActionResult<Usuarios>> Login([FromBody] Usuarios usuario)
        {
            var usuarioDb = await _repository.GetByName(usuario.Nome);
            if (usuarioDb is null)
            {
                return NotFound();
            }

            var token = _tokenService.GetTokenAsync(usuarioDb);

            return Ok(new
            {
                Usuario = usuarioDb,
                token = token.Result
            });
        }
    }
}
