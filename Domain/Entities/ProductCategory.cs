using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;

        // Navigation properties
        public List<ProductCategoryRelation> productCategoryRelations { get; set; } = new List<ProductCategoryRelation>();
    }
}