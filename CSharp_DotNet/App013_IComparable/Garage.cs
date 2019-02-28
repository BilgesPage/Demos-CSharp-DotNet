using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App013_IComparable
{
    class Garage : IEnumerable
    {
        Car[] cars = new Car[4];

        public Garage()
        {
            cars[0] = new Car { CarId = 23, CarBrand = "Opel", MaxSpeed = 200 };
            cars[1] = new Car { CarId = 1, CarBrand = "Mercedes", MaxSpeed = 250 };
            cars[2] = new Car { CarId = 129, CarBrand = "Audi", MaxSpeed = 210 };
            cars[3] = new Car { CarId = 3, CarBrand = "Ford", MaxSpeed = 200 };
        }


        public IEnumerator GetEnumerator()
        {
            return this.cars.GetEnumerator();
        }
    }
}
