namespace Task.Models
{
    public class Member
    {public int Id { get; set; }
        public string FullName {  get; set; }
        public int EmployeeId {  get; set; }
        public Employee Employee{  get; set; }
    }
}
