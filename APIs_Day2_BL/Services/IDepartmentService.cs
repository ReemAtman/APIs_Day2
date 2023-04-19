using APIs_Day2_BL.Dtos;
namespace APIs_Day2_BL.Services;
public interface IDepartmentService
{
    DepartmentDto? GetDepartmentDetailsWithTicketsById(int id);
}
