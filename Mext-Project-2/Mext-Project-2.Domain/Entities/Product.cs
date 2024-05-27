using Mext_Project_2.Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mext_Project_2.Domain.Entities
{
    public class Product : EntityBase
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }
}
