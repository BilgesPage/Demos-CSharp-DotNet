using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App011_IEnumerableInterface
{
    class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];


        public Garage()
        {
            carArray[0] = new Car { Brand = "Opel", Speed = 50 };
            carArray[1] = new Car { Brand = "Ford", Speed = 60 };
            carArray[2] = new Car { Brand = "Mercedes", Speed = 80 };
            carArray[3] = new Car { Brand = "Audi", Speed = 90 };
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }
}
