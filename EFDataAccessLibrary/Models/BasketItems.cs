using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class BasketItems : IProduct
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Basket category cannot be more than 100 characters!")]
        public string Category { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Basket name cannot be more than 100 characters!")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
