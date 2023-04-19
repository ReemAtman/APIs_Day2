using APIs_Day2_BL.Dtos;
using APIs_Day2_DAL.Repositories;
using AutoMapper;

namespace APIs_Day2_BL.Services;

public class DepartmentService : IDepartmentService
{
    private readonly IDepartmentRepository departmentRepository;  
    
    public DepartmentService(IDepartmentRepository _departmentRepository)
    {
      
        this.departmentRepository = _departmentRepository;       
    }
    public DepartmentDto? GetDepartmentDetailsWithTicketsById(int id)
    {        
        var department = departmentRepository.GetDepartmentDetailsWithTicketsById(id);
        if (department == null)
        {
            return null;
        }
        DepartmentDto departmentDto = new DepartmentDto();
        departmentDto.Id = id;
        departmentDto.Name = department?.Name;        
        var tickets = department?.Tikets;
        List<TicketsDepartmentDetails> ticketsDepartmentDetails = new List<TicketsDepartmentDetails>();
        
        foreach(var ticket in tickets) 
        {
            ticketsDepartmentDetails.Add(new TicketsDepartmentDetails()
            {
                Id = ticket.Id, 
                Description = ticket.Description,                
                DevelopersCount = ticket.Developers.Count()
            });
        }
        departmentDto.Tikets = ticketsDepartmentDetails;
        return departmentDto;
    }
}
