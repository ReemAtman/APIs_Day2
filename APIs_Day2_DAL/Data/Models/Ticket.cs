using Microsoft.Build.Framework;

namespace APIs_Day2_DAL;

    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public ICollection<Developer>? Developers { get; set; }
    }

