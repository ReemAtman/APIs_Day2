
using APIs_Day2_BL;
using APIs_Day2_BL.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace APIs_Day2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketSrvice ticketSrvice;
  
        public TicketController( ITicketSrvice ticketSrvice)
        {
            this.ticketSrvice = ticketSrvice;
      
        }

        [HttpGet]
        public ActionResult<IEnumerable<TicketDto>> GetAll()
        {
            return ticketSrvice.GetAll().ToList();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<TicketDto?> GetById(int id)
        {
            return Ok( ticketSrvice.GetById(id));
        }
        [HttpPost]
        public ActionResult Add(TicketDto ticketDto)
        {
            if (ticketSrvice.Add(ticketDto) == true)
            {
                ticketSrvice.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

        [HttpPatch]
        [Route("{id}")]
        public ActionResult Edit(TicketDto newticketDto,int id)
        {
            if (newticketDto.Id != id)
            {
                return BadRequest();
            }

            var oldTicketDto = ticketSrvice.GetById(id);
            if (oldTicketDto == null) {
                return NotFound();
                
            }
          
            if (ticketSrvice.Update(oldTicketDto, newticketDto) == true)
            {
                ticketSrvice.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete]      
        public ActionResult Delete(TicketDto ticketDto)
        {
            if (ticketSrvice.Delete(ticketDto) == true)
            {
                ticketSrvice.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}
