using APIs_Day2_DAL;
namespace APIs_Day2_BL.Dtos
{
    public class DepartmentDto
    {
        public int Id { get; set; }       
        public string? Name { get; set; }
        public List<TicketsDepartmentDetails>? Tikets { get; set; }
       
    }
}
