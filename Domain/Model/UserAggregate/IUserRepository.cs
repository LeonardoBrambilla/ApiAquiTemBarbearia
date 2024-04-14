using ApiAquiTemBarbearia.Domain.DTOs;
using ApiAquiTemBarbearia.Domain.Model.UserAggregate;

namespace ApiAquiTemBarbearia.Domain.Model.UserAggregate
{
    public interface IUserRepository
    {
        void Add(User user);
        List<UserDTO> Get();
    }
}
