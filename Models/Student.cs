using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Minimum length 2")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Only letter allowed")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Minimum length 2 max length 30")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Only letter allowed")]
        public string LastName { get; set; }
        [Display(Name = "Age")]
        [Required]
        [Range(1, 99, ErrorMessage = "It must be between 1-99")]
        public int Age { get; set; }
        [Display(Name = "Personal Number")]
        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Minimum length 5 max length 10")]
        public int PersonalNumber { get; set; }
        public ICollection<Parent>? Parents { get; set; }
        public int? SchoolId { get; set; }

        public School? School { get; set; }
    }
}
