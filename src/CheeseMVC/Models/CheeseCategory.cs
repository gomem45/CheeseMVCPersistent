using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Add Cheeses to CheeseCategory
        public IList<Cheese> Cheeses { get; set; }

    }
}
