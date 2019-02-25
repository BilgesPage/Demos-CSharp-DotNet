using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App010_CustomApplicationException
{
    class ElectronicCarDive : ICarDevice, IElectronicDevice
    {
        public bool IsOn { get; set; }

        public virtual void TurnOff()
        {
            this.IsOn = false;
        }

        public virtual void TurnOn()
        {
            this.IsOn = true;
        }
    }
}
