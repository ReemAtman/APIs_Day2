using APIs_Day2_DAL.Data.Context;
namespace APIs_Day2_DAL.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TicketsContext _context;

        public TicketRepository(TicketsContext context)
        {
            _context = context;
        }
        public bool Add(Ticket entity)
        {
            if (entity != null)
            {
                _context.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(Ticket entity)
        {
            if (entity != null)
            {
                _context.Set<Ticket>().Remove(entity);
                return true;
            }
            return false;
        }       

        public IEnumerable<Ticket> GetAll()
        {            
            return _context.Set<Ticket>().ToList();
        }

        public IEnumerable<Ticket> GetByDepartmentId(int id)
        {
            return _context.Set<Ticket>().ToList().Where(t => t.DepartmentId == id);
        }

        public Ticket? GetById(int id)
        {
            return _context.Set<Ticket>().FirstOrDefault(t=>t.Id==id);
        }

        public bool SaveChanges()
        {

            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(Ticket oldEntity, Ticket newEntity)
        {
            if (oldEntity != null)
            {
                oldEntity.Title = newEntity.Title;
                oldEntity.Description = newEntity.Description;
                oldEntity.Id = newEntity.Id;
                oldEntity.DepartmentId = newEntity.DepartmentId;
                oldEntity.Developers = newEntity.Developers;
                _context.Update(oldEntity);
                return true;
            }
            return false;
        }
        
    }
}
