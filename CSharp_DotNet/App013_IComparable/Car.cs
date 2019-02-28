using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App013_IComparable
{
    class Car : IComparable
    {
        public Car()
        {
        }

        public Car(int carId, string carBrand, int maxSpeed)
        {
            CarId = carId;
            CarBrand = carBrand;
            MaxSpeed = maxSpeed;
        }

        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public int MaxSpeed { get; set; }

        public int CompareTo(object obj)
        {
            Car compareCar = obj as Car;

            if (compareCar != null)
            {
                //if (compareCar.CarId > this.CarId)
                //{
                //    return 1;
                //}
                //else if (compareCar.CarId == this.CarId)
                //{
                //    return 0;
                //}
                //else if (compareCar.CarId < this.CarId)
                //{
                //    return -1;
                //}

                return this.CarId.CompareTo(compareCar.CarId);
            }
            else
            {
                throw new ArgumentException("Object is not a car.");
            }
        }
    }
}
