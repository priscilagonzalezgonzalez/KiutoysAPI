using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DB.Models;

namespace DB.Models
{
    public class ProductCategoryRelation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        // Foreign Keys
        [Required]
        public required int ProductId { get; set; } 
        [Required]
        public required int ProductCategoryId { get; set; } 

        // Navigation properties
        [ForeignKey("ProductId")]
        public required Product Product { get; set; }
        [ForeignKey("ProductCategoryId")]
        public required ProductCategory ProductCategory { get; set; }
    }
}