namespace APIs_Day2_DAL.Repositories
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAll();
        Ticket? GetById(int id);
        bool Add(Ticket entity);
        bool Update(Ticket oldEntity, Ticket newEntity);
        bool Delete(Ticket entity);
        bool SaveChanges();      
        IEnumerable<Ticket> GetByDepartmentId(int id);
    }
}
