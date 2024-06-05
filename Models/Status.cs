using System.ComponentModel.DataAnnotations;

namespace EffectiveUsers.Models
{
    public class Status
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }
        [MaxLength(2)]
        [Required]
        public string? ST_ID { get; set; }
        [MaxLength(150)]
        [Required]
        public string? StatusName { get; set; }
    }
}
