using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App013_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();

            foreach (Car car in myGarage)
            {
                Console.WriteLine($"Id:{car.CarId}, Brand: {car.CarBrand}, Max Speed: {car.MaxSpeed}");
            }

            Car[] carArray = myGarage.Cast<Car>().ToArray();

            // Sort due to the IComparable implementation
            Array.Sort(carArray);

            Console.WriteLine("\nAfter IComparable (sort) application to the array");

            foreach (Car car in carArray)
            {
                Console.WriteLine($"Id:{car.CarId}, Brand: {car.CarBrand}, Max Speed: {car.MaxSpeed}");
            }

            Console.ReadLine();
        }
    }
}
