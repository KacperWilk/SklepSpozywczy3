using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SklepSpozywczy3.Models;

namespace SklepSpozywczy3.ViewModels
{
    public class ProductFormViewModel
    {
        public IEnumerable<CategoryType> CategoryTypes { get; set; }
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Quantity must be between 1 and 20")]
        public int? Quantity { get; set; }
        [Display(Name = "Category")]
        public byte? CategoryTypeId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public ProductFormViewModel()
        {
            Id = 0;
        }

        public ProductFormViewModel(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            Quantity = product.Quantity;
            CategoryTypeId = product.CategoryTypeId;
        }
    }
}