using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Contracts
{
    public interface ICalling
    {
        string PhoneNumbers { get; set; }
        public string Call();
    }
}
