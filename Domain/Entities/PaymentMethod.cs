using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PaymentMethod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;

        // Navigation properties
        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}