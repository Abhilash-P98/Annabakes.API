using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annabakes.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Weight { get; set; }
        public float KiloCalories { get; set; }
        public bool IsVegitarian { get; set; }
        public bool IsSpecial { get; set; }
    }
}
