using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Core.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; } //plastic , organic etc
        [StringLength(200)]
        public decimal Cost { get; set; }
        public string Description { get; set; }
    }
}
