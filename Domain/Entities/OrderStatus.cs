using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name {get; set; } = string.Empty;
        public string? Description { get; set; } =  string.Empty;

        // Navegation Properties
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}