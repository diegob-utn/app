using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Sucursal
    {
                public string Location { get; set; }
        public List<Producto> Products { get; set; }

        public Sucursal(string location)
        {
            Location = location;
            Products = new List<Producto>();
        }

        public void AddProduct(Producto product)
        {
            Products.Add(product);
        }

        public void DisplayProducts()
        {
            Console.WriteLine($"Products available at {Location}:");
            foreach (var product in Products)
            {
                product.DisplayInfo();
            }
        }
    }
}
