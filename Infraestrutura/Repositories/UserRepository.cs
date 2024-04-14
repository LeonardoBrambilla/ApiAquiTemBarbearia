using ApiAquiTemBarbearia.Domain.DTOs;
using ApiAquiTemBarbearia.Domain.Model.UserAggregate;

namespace ApiAquiTemBarbearia.Infraestrutura.Repositories
{
    public class UserRepository(ConnectionContext context) : IUserRepository
    {
        private readonly ConnectionContext _context = context;

        void IUserRepository.Add(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }
        public List<UserDTO> Get()
        {
            throw new NotImplementedException();
        }
    }
}
