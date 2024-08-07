using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class CartItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }

        // Foreign Keys
        [Required]
        public required int ProductId { get; set; }
        public int? UserId { get; set; }

        // Navigation properties
        [ForeignKey("ProductId")]
        public required Product Product { get; set; }
        [ForeignKey("UserId")]
        public UserAccount? UserAccount { get; set; }
    }
}