using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Producto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Producto(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Name: {Name}, Price: {Price}");
        }
    }
}
