using APIs_Day2_BL.Dtos;
namespace APIs_Day2_BL;

    public interface ITicketSrvice
    {
        IEnumerable<TicketDto> GetAll();
        TicketDto? GetById(int id);
        bool Add(TicketDto entity);
        bool Update(TicketDto oldTicketDto, TicketDto newTicketDto);
        bool Delete(TicketDto entity);
        bool SaveChanges();
    }

