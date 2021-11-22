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
    public class BundleItems : IProduct
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int ProductID { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Bundle category cannot be more than 100 characters!")]
        public string Category { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Bundle name cannot be more than 100 characters!")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int BundlesId { get; set; }
    }
}
