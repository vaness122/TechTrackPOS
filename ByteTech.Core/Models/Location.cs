using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Core.Models
{
    public class Location
    {
        public  int Id { get; set; }
        public string Code { get; set; } //store-01 ,wh - 01 etc
        [StringLength(200)]
        public string Description { get; set; }
        public string Name { get; set; } //main branch etc
    }
}
