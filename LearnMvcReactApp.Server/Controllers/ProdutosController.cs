using LearnMvcReactApp.Server.Models;
using LearnMvcReactApp.Server.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace LearnMvcReactApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class ProdutosController : GenericController<Produtos, IGenericsRepository<Produtos>>
    {
        public ProdutosController(IGenericsRepository<Produtos> repository) : base(repository)
        {
        }

        protected override int GetEntityId(Produtos entity)
        {
            throw new NotImplementedException();
        }

        protected override void UpdateEntity(Produtos existingEntity, Produtos newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
