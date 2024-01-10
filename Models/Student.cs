using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Personal Number")]
        public int PersonalNumber { get; set; }
        public ICollection<Parent>? Parents { get; set; }
        public int? SchoolId { get; set; }

        public School? School { get; set; }
    }
}
