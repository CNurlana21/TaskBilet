using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class Position
    {public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Member> Members { get; set; }
        public bool IsDeleted { get; set; }
    }
}
