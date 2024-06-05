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
        [MaxLength(50)]
        [Required]
        public string? FristName { get; set; }
        [MaxLength(50)]
        [Required]
        public string? LastName { get; set; }
        [MaxLength(40)]
        [Required]
        public string? UserLogin { get; set; }
        [MaxLength(20)]
        [Required]
        public string? Password { get; set; } = "123456"; 
        [MaxLength(100)]
        [Required]
        public string? Email { get; set; }
        [MaxLength(500)]
        [Required]
        public string? Address { get; set; }
        [MaxLength(2)]
        [Required]
        public string? ST_ID { get; set; }
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