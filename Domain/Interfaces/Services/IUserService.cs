using Domain.Dtos.User;

namespace Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<UserDto> Get(int id);
    }
}
