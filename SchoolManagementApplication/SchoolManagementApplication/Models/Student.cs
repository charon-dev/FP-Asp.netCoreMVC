using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementApplication.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [Range(18, 25)]
        public int Age { get; set; }
        public string CodeSector { get; set; }
        [ForeignKey("CodeSector")]
        [ValidateNever]
        public Sector Sector { get; set; }
    }
}
