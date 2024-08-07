using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Stock { get; set; }

        [Column(TypeName = "decimal(10,2)")] 
        public decimal Cost { get; set; }
        [Column(TypeName = "decimal(10,2)")] 
        [Required]
        public decimal Price { get; set; }

        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Foreign Keys

        // Navigation properties
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public List<ProductCategoryRelation> productCategoryRelations { get; set; } = new List<ProductCategoryRelation>();
    }
}