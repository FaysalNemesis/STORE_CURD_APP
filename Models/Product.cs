using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace StoreCURDApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        [MaxLength(50)]
        public string Brand { get; set; }
        [MaxLength(100)]
        public string Category { get; set; }
        [Precision(16 ,2)]
        public decimal Price { get; set; }
        [MaxLength(100)]
        public string ProductImageName { get; set; }
        public DateTime creaetedAt { get; set; }


    }
}
