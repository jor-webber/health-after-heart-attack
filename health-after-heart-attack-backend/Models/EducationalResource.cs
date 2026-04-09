using System.ComponentModel.DataAnnotations;

namespace HealthAfterHeartAttack.Models
{
    public class EducationalResource
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public string Url { get; set; }
    }
}