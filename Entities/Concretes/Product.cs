using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public decimal UnitePrice { get; set; }
        public int Unit { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
