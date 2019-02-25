using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App010_CustomApplicationException
{
    class Car
    {
        public const int MaxSpeed = 100;

        public Car(int currentSpeed)
        {
            if(CurrentSpeed == 0) Console.WriteLine("Engine started");
            CurrentSpeed = currentSpeed;
        }

        public Car()
        {
            if (CurrentSpeed == 0) Console.WriteLine("Engine started");
        }

        public int CurrentSpeed { get; set; }
        public bool CarIsDead { get; set; }
        public Radio CarRadio = new Radio();


        public void Accelerate(int acceleration)
        {
            CurrentSpeed += acceleration;

            if (CurrentSpeed > MaxSpeed)
            {
                CarIsDead = true;
                Exceptions.CarIsDeadException deadException = new Exceptions.CarIsDeadException("Car has overheated.", DateTime.Now, "You better buy a sports car");
                throw deadException;
            }
            else
            {
                Console.WriteLine("Car accelerated");
            }
        }

    }
}
