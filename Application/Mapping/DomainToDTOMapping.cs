using AutoMapper;
using ApiAquiTemBarbearia.Domain.DTOs;
using ApiAquiTemBarbearia.Domain.Model.UserAggregate;

namespace ApiAquiTemBarbearia.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Name, m => m.MapFrom(orig => orig.Name));
        }
    }
}
