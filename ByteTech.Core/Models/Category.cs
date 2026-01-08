using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Core.Models
{
   public class Category
    {
        public int Id { get;private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public Category (int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

    }
}
