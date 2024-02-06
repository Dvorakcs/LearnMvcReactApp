using LearnMvcReactApp.Server.Models;

namespace LearnMvcReactApp.Server.Services.Interfaces
{
    public interface ITokenService
    {
        Task<string> GetTokenAsync(Usuarios Usuario);
    }
}
