using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepSpozywczy3.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(1,20, ErrorMessage = "Quantity must be between 1 and 20")]
        public int Quantity { get; set; }
        public CategoryType CategoryType { get; set; }
        [Display(Name = "Category")]
        public byte CategoryTypeId { get; set; }
    }
}