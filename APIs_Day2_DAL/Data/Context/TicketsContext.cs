
using Microsoft.EntityFrameworkCore;
namespace APIs_Day2_DAL.Data.Context
{
    public class TicketsContext : DbContext
    {
        public TicketsContext(DbContextOptions<TicketsContext> options)
           : base(options)
        {

        }
        public DbSet<Ticket> Tickets => Set<Ticket>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Developer> Developers => Set<Developer>();

       
    }
}
