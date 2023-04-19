using APIs_Day2_DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
namespace APIs_Day2_DAL.Repositories;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly TicketsContext _context;

    public DepartmentRepository(TicketsContext context)
    {
        _context = context;
    }
    public Department? GetDepartmentDetailsWithTicketsById(int id)
    {
        return _context.Set<Department>()?.Include(t => t.Tikets).ThenInclude(t => t.Developers).FirstOrDefault(t => t.Id == id);
       
    }
}
