using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App010_CustomApplicationException.Exceptions
{
    class CarIsDeadException : ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException(string messageDetails, DateTime errorTimeStamp, string causeOfError): base(messageDetails)
        {
            ErrorTimeStamp = errorTimeStamp;
            CauseOfError = causeOfError;
        }

        //public override string Message => $"Car Error: {messageDetails} ";


    }
}
