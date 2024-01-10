using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Parent
    {
        public int ID { get; set; }
        [Display(Name = "Parent First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Parent Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Parent Address")]
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public int? StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
