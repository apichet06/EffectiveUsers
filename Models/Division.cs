using System.ComponentModel.DataAnnotations;

namespace EffectiveUsers.Models
{
    public class Division
    {
        [MaxLength(10)]
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        [Required]
        public string? DV_ID { get; set; }
        [MaxLength(100)]
        [Required]
        public string? DVName { get; set; }
    }
}
