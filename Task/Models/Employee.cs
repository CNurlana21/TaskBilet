namespace Task.Models
{
    public class Employee
    {public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
