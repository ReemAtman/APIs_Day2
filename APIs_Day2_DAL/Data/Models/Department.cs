
using Microsoft.Build.Framework;
namespace APIs_Day2_DAL;

public class Department
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    public ICollection<Ticket>? Tikets { get; set; } 
}
