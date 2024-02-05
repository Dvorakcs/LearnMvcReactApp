using LearnMvcReactApp.Server.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public abstract class GenericController<T> : ControllerBase where T : class
{
    private readonly IGenericsRepository<T> _repository;

    public GenericController(IGenericsRepository<T> repository)
    {
        _repository = repository;
    }

    // GET api/[controller]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<T>>> GetAsync()
    {
        var entities = await _repository.GetAll();
        return Ok(entities);
    }

    // GET api/[controller]/5
    [HttpGet("{id}")]
    public async Task<ActionResult<T>> GetAsync(int id)
    {
        var entity = await _repository.GetById(id);
        if (entity == null)
        {
            return NotFound();
        }
        return Ok(entity);
    }

    // POST api/[controller]
    [HttpPost]
    public async Task<ActionResult> PostAsync([FromBody] T entity)
    {
        await _repository.Add(entity);
        return Ok(entity);
    }

    // PUT api/[controller]/5
    [HttpPut("{id}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] T entity)
    {
        var existingEntity = await _repository.GetById(id);
        if (existingEntity == null)
        {
            return NotFound();
        }

        UpdateEntity(existingEntity, entity);

        await _repository.Update(existingEntity);

        return NoContent();
    }

    // DELETE api/[controller]/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        var entity = await _repository.GetById(id);
        if (entity == null)
        {
            return NotFound();
        }

        await _repository.Delete(id);

        return NoContent();
    }

    // Método abstrato para obter o ID da entidade
    protected abstract int GetEntityId(T entity);

    // Método abstrato para atualizar a entidade existente com base na recebida
    protected abstract void UpdateEntity(T existingEntity, T newEntity);
}
