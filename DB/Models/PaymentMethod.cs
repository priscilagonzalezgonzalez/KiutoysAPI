using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DB.Models;

namespace DB.Models
{
    public class PaymentMethod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;

        // Navigation properties
        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}