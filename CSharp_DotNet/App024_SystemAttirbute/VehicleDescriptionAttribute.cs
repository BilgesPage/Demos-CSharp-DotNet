using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App024_SystemAttirbute
{
    class VehicleDescriptionAttribute : Attribute
    {
        public VehicleDescriptionAttribute()
        {
        }

        public VehicleDescriptionAttribute(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}
