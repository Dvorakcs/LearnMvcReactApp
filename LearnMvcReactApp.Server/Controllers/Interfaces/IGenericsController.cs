namespace LearnMvcReactApp.Server.Controllers.Interfaces
{
    public interface IGenericsController<T>
        where T : class 
    {
       Task<T> Add(T entity);
       Task<T> Update(T entity);
       Task Remove(T entity);
       Task<T> GetById(int id);
       Task<IEnumerable<T>> GetAll();

    }
}
