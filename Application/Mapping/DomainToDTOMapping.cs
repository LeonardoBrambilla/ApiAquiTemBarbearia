using AutoMapper;
using ApiAquiTemBarbearia.Domain.DTOs;
using ApiAquiTemBarbearia.Domain.Model.EmployeeAggregate;

namespace ApiAquiTemBarbearia.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, m => m.MapFrom(orig => orig.name));
        }
    }
}
