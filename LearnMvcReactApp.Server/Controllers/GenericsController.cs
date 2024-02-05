using LearnMvcReactApp.Server.Controllers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LearnMvcReactApp.Server.Controllers
{
    public class GenericsController<T> : IGenericsController<T> where T : class
    {
        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
