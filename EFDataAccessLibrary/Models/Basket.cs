using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Basket
    {
        [JsonIgnore]
        public int Id { get; set; }
        public List<BasketItems> BasketItems { get; set; } = new List<BasketItems>();

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }
    }
}
