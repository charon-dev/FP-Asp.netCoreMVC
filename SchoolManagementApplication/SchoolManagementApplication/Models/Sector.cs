using System.ComponentModel.DataAnnotations;

namespace SchoolManagementApplication.Models
{
    public class Sector
    {
        [Key]
        public string Code { get; set; } 
        [Required]
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Module> Modules { get; set; } = new List<Module>();

    }
}
