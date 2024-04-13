using ApiAquiTemBarbearia.Domain.DTOs;
using ApiAquiTemBarbearia.Domain.Model.UserAggregate;

namespace ApiAquiTemBarbearia.Domain.Model.EmployeeAggregate
{
    public interface IUserRepository
    {
        void Add(User employee);

        List<UserDTO> Get(int pageNumber, int pageQuantity);
        User? Get(int id);
    }
}
