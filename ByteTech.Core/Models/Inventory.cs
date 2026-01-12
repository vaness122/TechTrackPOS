using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Core.Models
{
    public class Inventory
    { // location specific
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product{ get; set; }

        public int Quantity { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }

        public int Stock {  get; set; }
        public int ReservedStock { get; set; } //orders being processed
        public int AvailableStock => Stock - ReservedStock;

      


    }
}
