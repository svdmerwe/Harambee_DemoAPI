using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Product : IProduct
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Product name cannot be more than 100 characters!")]
        public string Name { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Product category cannot be more than 100 characters!")]
        public string Category { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
