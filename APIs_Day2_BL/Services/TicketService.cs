using APIs_Day2_BL.Dtos;
using APIs_Day2_DAL;
using APIs_Day2_DAL.Repositories;
using AutoMapper;

namespace APIs_Day2_BL.Services
{
    public class TicketService : ITicketSrvice
    {
        private readonly ITicketRepository ticketRepository;
        public IMapper Mapper { get; }

        public TicketService(ITicketRepository _ticketRepository, IMapper _mapper)
        {
            ticketRepository = _ticketRepository;
            Mapper = _mapper;

        }

        public IEnumerable<TicketDto> GetAll()
        {
            List<TicketDto> readTicketDtos = Mapper.Map<List<TicketDto>>(ticketRepository.GetAll());
            return readTicketDtos.ToList();
        }

        public TicketDto? GetById(int id)
        {
            var ticket = Mapper.Map<TicketDto>(ticketRepository.GetById(id));
            return (ticket);
        }

        public bool Add(TicketDto entity)
        {
            if (entity != null)
            {
                ticketRepository.Add(Mapper.Map<Ticket>(entity));
                return true;
            }
            return false;

        }

        public bool Update(TicketDto oldTicketDto , TicketDto newTicketDto)
        {
            if (oldTicketDto != null)
            {
                var oldTicket = Mapper.Map<Ticket>(oldTicketDto);
                var newTicket = Mapper.Map<Ticket>(oldTicketDto);                
                ticketRepository.Update(oldTicket, newTicket);                
                return true;
            }
            return false;
        }

        public bool Delete(TicketDto entity)
        {
            if (entity != null)
            {
                ticketRepository.Delete(Mapper.Map<Ticket>(entity));
                return true;
            }
            return false;
        }

        public bool SaveChanges()
        {
           
          if( ticketRepository.SaveChanges() == true)
                return true;
          return false;
             
        }
    }
}
