namespace Proiect.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Grade>? Grades { get; set; }
    }
}
