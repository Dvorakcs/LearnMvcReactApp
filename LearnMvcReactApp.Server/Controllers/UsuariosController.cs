using LearnMvcReactApp.Server.Models;
using LearnMvcReactApp.Server.Repositories;
using LearnMvcReactApp.Server.Repositories.IRepositories;
using LearnMvcReactApp.Server.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LearnMvcReactApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : GenericController<Usuarios, IUsuariosRepository>
    {
        private readonly IUsuariosRepository _usuarioRepository;
        private readonly ITokenService _tokenService;

        public UsuariosController(IUsuariosRepository usuariosRepository, ITokenService tokenService)
            : base(usuariosRepository)
        {
            _usuarioRepository = usuariosRepository;
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
        [Route("login/")]
        public async Task<ActionResult<Usuarios>> Login([FromBody] Usuarios usuario)
        {
            var usuarioDb = await _usuarioRepository.GetByName(usuario.Nome);
            if(usuarioDb is null)
            {
                return NotFound();
            }
            var Token = await _tokenService.GetTokenAsync(usuarioDb);

            return Ok(new
            {
                token=Token,
                usuario = usuarioDb,
            });
        }
    }
}
