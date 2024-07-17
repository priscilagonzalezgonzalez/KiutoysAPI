using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DB.Models;

namespace DB.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty; // CHANGE TO ENUM OR CREATE NEW TABLE
        [Column(TypeName = "decimal(18,2)")] public decimal TotalAmount { get; set; }
        
        // Foreign Keys
        [Required]
        public required int DeliveryId { get; set; }
        [Required]
        public required int OrderStatusId { get; set; }

        // Navigation properties
        [ForeignKey("DeliveryId")]
        public required DeliveryInfo DeliveryInfo { get; set; }
        [ForeignKey("OrderStatusId")]
        public required OrderStatus OrderStatus { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public required Payment Payment { get; set; }
    }
}