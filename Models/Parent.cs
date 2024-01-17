using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Parent
    {

        public int ID { get; set; }
        [Display(Name = "Parent First Name")]
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Minimum length 2")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Only letter allowed")]
        public string FirstName { get; set; }
        [Display(Name = "Parent Last Name")]
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Minimum length 2")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Only letter allowed")]
        public string LastName { get; set; }
        [Display(Name = "Parent Address")]
        [Required]
        public string Address { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "The length must be 10")]
        [RegularExpression(@"^[0-9]",ErrorMessage = "Only number allowed between 0-9")]
        public string PhoneNumber { get; set; }
        [Required]
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
