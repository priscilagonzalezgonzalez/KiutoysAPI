using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DB.Models;

namespace DB.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        [Column(TypeName = "decimal(10,2)")] 
        public decimal TotalAmount { get; set; }

        // Foreign Keys
        public required int MethodId { get; set; }
        public required int OrderId { get; set; }
        
        // Navigation properties
        [ForeignKey("OrderId")]
        public required Order Order { get; set; }
        [ForeignKey("MethodId")]
        public required PaymentMethod PaymentMethod { get; set; }
    }
}