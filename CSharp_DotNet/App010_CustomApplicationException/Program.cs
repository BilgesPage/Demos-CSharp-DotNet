using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App010_CustomApplicationException
{

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.CarRadio.TurnOn();

            try
            {
                myCar.Accelerate(100);
                myCar.Accelerate(10);
            }
            catch (Exceptions.CarIsDeadException ex) when (myCar.CarRadio.IsOn == false) // According to this silly application you can not drive fast if the radio is not on.
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ErrorTimeStamp);
                Console.WriteLine(ex.CauseOfError);
            }


            Console.ReadLine();
        }
    }
}
