using APIs_Day2_BL.Dtos;
using APIs_Day2_DAL;
using AutoMapper;

namespace APIs_Day2_BL.Helpers
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Ticket, TicketDto>().ReverseMap()
            .ForMember(c => c.Department, option => option.Ignore())
            .ForMember(c => c.Developers, option => option.Ignore());
                           
            CreateMap<DepartmentDto, Department>().ReverseMap();


        }

    }
}
