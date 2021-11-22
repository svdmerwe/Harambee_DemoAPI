using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Order
    {
        //[JsonIgnore]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Basket Basket { get; set; }
    }
}
