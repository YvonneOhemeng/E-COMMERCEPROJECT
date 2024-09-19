using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Order
    {
        // Unique identifier for each order
        public int Id { get; set; }

        // Customer's name who placed the order
        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        // Customer's email
        [Required]
        [EmailAddress]
        public string CustomerEmail { get; set; }

        // Order date
        [Required]
        public DateTime OrderDate { get; set; }

        // Total amount of the order
        [Required]
        [Range(0.01, 100000.00)]
        public decimal TotalAmount { get; set; }
    }
}