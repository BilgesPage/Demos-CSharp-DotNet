using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App025_UsingDynamicDataInComInterop
{
    class Car
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public List<Car> Cars => new List<Car>() {
                new Car{ Color = "Red", Brand ="Opel"},
                new Car{ Color = "Blue", Brand = "Ford"},
                new Car{ Color = "Black", Brand = "Mercedes"},
                new Car{ Color = "White", Brand = "Audi"},
            };
    }
}
