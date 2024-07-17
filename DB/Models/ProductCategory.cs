using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DB.Models;

namespace DB.Models
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