using ApiAquiTemBarbearia.Domain.DTOs;

namespace ApiAquiTemBarbearia.Domain.Model.EmployeeAggregate
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<EmployeeDTO> Get(int pageNumber, int pageQuantity);
        Employee? Get(int id);
    }
}
