using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DB.Models;

namespace DB.Models
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