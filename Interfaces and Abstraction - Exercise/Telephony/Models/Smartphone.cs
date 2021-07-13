using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Contracts;

namespace Telephony.Models
{
    public class Smartphone : ICalling, ISurfing
    {
        public string PhoneNumbers { get; set; }
        public string UrlSurf { get; set; }

        public string Call()
        {
            if (!this.PhoneNumbers.All(x => char.IsDigit(x)))
            {
                throw new Exception("Invalid number!");
            }

            return $"Calling... {this.PhoneNumbers}";
        }

        public string Surf()
        {
            if (this.UrlSurf.Any(x => char.IsDigit(x)))
            {
                throw new Exception("Invalid URL!");
            }

            return $"Browsing: {this.UrlSurf}!";
        }
    }
}
