using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }

        //Foreign Keys
        [Required]
        public required int OrderId { get; set; }
        [Required]
        public required int ProductId { get; set; }
        
        // Navigation properties
        public required Order Order { get; set; }
        public required Product Product { get; set; }
    }
}