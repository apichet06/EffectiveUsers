using System.ComponentModel.DataAnnotations;

namespace EffectiveUsers.Models
{
    public class Users
    {
        [MaxLength(10)]
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        [Required]
        public string? U_ID { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        [MaxLength(40)]
        [Required]
        public string? UserLogin { get; set; }
        [MaxLength(20)]
        [Required]
        public string? Password { get; set; } = "123456";
        [MaxLength(50)]
        [Required]
        public string? Username { get; set; }
        [MaxLength(1)]
        [Required]
        public string? Status { get; set; }
        [MaxLength(10)]
        [Required]
        public string? DV_ID { get; set; }
        [MaxLength(10)]
        [Required]
        public string? P_ID { get; set; }
        [Required]
        public DateTime EffectiveDate { get; set; }
        public DateTime EffectiveUpdateDate { get; set; }
    }
}