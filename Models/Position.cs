using System.ComponentModel.DataAnnotations;

namespace EffectiveUsers.Models
{
    public class Position
    {
        [MaxLength(10)]
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        [Required]
        public string? P_ID { get; set; }
        [MaxLength(100)]
        [Required]
        public string? P_Name { get; set; }
    }
}
