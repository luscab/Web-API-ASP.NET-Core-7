using AutoMapper;
using WebAPI.Domain.DTOs;
using WebAPI.Domain.Model.EmployeeAggregate;

namespace WebAPI.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.age))
                .ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.photo));
        }
    }
}
