using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Contracts
{
    public interface ISurfing
    {
        string UrlSurf { get; set; }
        public string Surf();
    }
}
