using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App016_Event
{
    class Program
    {
        class Car
        {
            public int Speed { get; set; }

            public void SpeedUp()
            {
                Speed += 10;
                Console.WriteLine($"Current Speed: {Speed}");
            }

            public void SlowDown()
            {
                Speed -= 10;
                Console.WriteLine($"Current Speed: {Speed}");
            }

            public void TurnOnRadio() => Console.WriteLine($"Radio is On");

            public void TurnOnffRadio() => Console.WriteLine($"Radio is Off");


            // Delegation & Events

            public delegate void CarHandler();

            public event CarHandler CarSpeedEvent;
            public event CarHandler CarRadioEvent;

        }

        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.CarRadioEvent += new Car.CarHandler(myCar.TurnOnRadio);
            myCar.CarSpeedEvent += new Car.CarHandler(myCar.SpeedUp);
            myCar.CarSpeedEvent += new Car.CarHandler(myCar.SlowDown);
            myCar.CarSpeedEvent += MyCar_CarSpeedEvent;

            myCar.SpeedUp();

            Console.ReadLine();
        }

        private static void MyCar_CarSpeedEvent()
        {
            throw new NotImplementedException();
        }
    }
}
