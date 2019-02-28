using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App011_IEnumerableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage newGarage = new Garage();

            IEnumerable<Car> CarNameEdit(Garage garage)
            {
                foreach (Car car in garage)
                {
                    yield return new Car { Brand = car.Brand + " 2019", Speed = car.Speed };
                }
            }

            foreach (Car c in CarNameEdit(newGarage))
            {
                Console.WriteLine($"Brand: {c.Brand}, Speed: {c.Speed}");
            }

            Console.ReadLine();
        }
    }
}
