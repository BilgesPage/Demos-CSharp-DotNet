using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App030_Serialization_XmlSerializer
{
    [Serializable]
    public class Car
    {
        public string Color { get; set; }
        public string Brand { get; set; }

        [NonSerialized]
        private int privateNo = 34657;
    }
}
