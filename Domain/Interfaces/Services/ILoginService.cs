using Domain.Dtos.User;

namespace Domain.Interfaces.Services
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto loginDto);
    }
}
