namespace Proiect.Models
{
    public class Grade
    {
        public int ID { get; set; }
        public int Value { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int SubjectId { get; set; }
        public Subject? Subject{ get; set; }
    }
}