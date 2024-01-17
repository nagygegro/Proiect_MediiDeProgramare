using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Subject
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Grade>? Grades { get; set; }
    }
}
