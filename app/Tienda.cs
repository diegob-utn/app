using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{

    public class Tienda
    {
        public string Name { get; set; }
        public List<Sucursal> Sucursales { get; set; }

        public Tienda(string name)
        {
            Name = name;
            Sucursales = new List<Sucursal>();
        }

        public void AddSucursal(Sucursal sucursal)
        {
            Sucursales.Add(sucursal);
        }

        public void DisplaySucursales()
        {
            Console.WriteLine($"Sucursales of {Name}:");
            foreach (var sucursal in Sucursales)
            {
                Console.WriteLine(sucursal.Location);
            }
        }
    }
}