using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class School
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Minimum length 5")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Only letter allowed")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
