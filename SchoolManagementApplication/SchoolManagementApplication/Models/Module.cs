using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementApplication.Models
{
    public class Module
    {
        [Key]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Hours { get; set; }
        public string CodeSector { get; set; }
        [ForeignKey("CodeSector")]
        public Sector Sector { get; set; } 
    }
}
