using APIs_Day2_DAL;
using System.ComponentModel.DataAnnotations;

namespace APIs_Day2_BL.Dtos;

public class TicketDto
{
    
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    public int DepartmentId { get; set; }
    

}
