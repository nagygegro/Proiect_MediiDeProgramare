using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Grade
    {
        public int ID { get; set; }
        [Required]
        [Range(1, 10)]
        public int Value { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int SubjectId { get; set; }
        public Subject? Subject{ get; set; }
    }
}