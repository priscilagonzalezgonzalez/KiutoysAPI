using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class DeliveryInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string FirstName {get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string LastName {get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Phone]
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public bool IsGuest { get; set; }

        // Foreign Keys
        [Required]
        public required int AddressId { get; set; } 
        public int? UserId { get; set; }

        // Navigation properties
        [ForeignKey("AddressId")]
        public required Address Address { get; set; }
        [ForeignKey("UserId")]
        public UserAccount? UserAccount { get; set; }
        
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}