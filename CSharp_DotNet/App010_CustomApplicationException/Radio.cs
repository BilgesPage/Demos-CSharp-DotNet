using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App010_CustomApplicationException
{
    class Radio: ElectronicCarDive
    {
        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine("Radio is On");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine("Radio is Off");
        }

    }
}
