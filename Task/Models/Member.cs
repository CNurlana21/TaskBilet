using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class Member
    {public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        public string ImageUrl { get; set; }
        public int PositionId {  get; set; }
        public Position Position{  get; set; }
        public bool IsDeleted { get; set; }
    }
}
