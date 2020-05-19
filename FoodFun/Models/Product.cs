using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodFun.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("Author")]
        public string AuthorId { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }
        public string PhotoPath { get; set; }
        [Required]
        [MaxLength(200)]
        public string Slug { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime? CreationTime { get; set; }
        [Required]
        public DateTime? ModificationTime { get; set; }

        public virtual ApplicationUser Author { get; set; } // ürünün yazarı
        public virtual Category Category { get; set; } // her ürünün kategorisi olur
    }
}