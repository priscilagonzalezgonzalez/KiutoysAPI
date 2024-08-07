using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ProductCategoryRelation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        // Foreign Keys
        [Required]
        [ForeignKey("Product")]
        public required int ProductId { get; set; } 

        [Required]
        [ForeignKey("ProductCategory")]
        public required int ProductCategoryId { get; set; } 

        // Navigation properties
        
        public required Product Product { get; set; }
        
        public required ProductCategory ProductCategory { get; set; }
    }
}