using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string StreetName { get; set; } = string.Empty;
        [Required]
        [MaxLength(25)]
        public string StreetNumber { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string Neighborhood { get; set; } = string.Empty;
        [Required]
        [MaxLength(25)]
        public string ZipCode { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string City { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string State { get; set; } = string.Empty;
        [MaxLength(255)]
        public string? Notes { get; set; } = string.Empty;

        // Navigation property
        public required DeliveryInfo DeliveryInfo { get; set; }
        
    }
}