using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App024_SystemAttirbute
{
    [Serializable]
    class MotorCycle
    {
        [VehicleDescription(Description = "This is description of motorcycle.")]
        [NonSerialized]
        float totalWeightOfPassengers;

        bool hasRadioSystem;
        bool hasHeadSet;
    }
}
