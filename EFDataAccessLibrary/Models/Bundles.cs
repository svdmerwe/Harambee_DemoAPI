using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Bundles
    {
        [JsonIgnore]
        public int Id { get; set; }

        public List<BundleItems> BundleItems { get; set; } = new List<BundleItems>();

        
        public int Discount { get; set; }
    }
}
