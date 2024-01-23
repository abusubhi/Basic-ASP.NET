using AutoMapper;
using BasicsAPI.Models;
using Model.DTOs;

namespace BasicsAPI
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration() 
        {
            CreateMap<Employee, ReqEmployeeDTO>()
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Name));
        }
    }
}
