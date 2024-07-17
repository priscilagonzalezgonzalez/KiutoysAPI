using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DB.Models;

namespace DB.Models
{
    public class UserAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty; 

        // Navigation property
        public List<DeliveryInfo> DeliveryInfo { get; set; } = new List<DeliveryInfo>();
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}