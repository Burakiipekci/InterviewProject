using Core.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDto:IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public decimal UnitePrice { get; set; }
        public int Unit { get; set; }
        
     
    }
}
