using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Telephony.Contracts;


namespace Telephony.Models
{
    class StationaryPhone : ICalling
    {
        public string PhoneNumbers { get; set; }

        public string Call()
        {
            if (!this.PhoneNumbers.All(x => char.IsDigit(x)))
            {
                throw new Exception("Invalid number!");
            }

            return $"Dialing... {this.PhoneNumbers}";
        }

    }
}
