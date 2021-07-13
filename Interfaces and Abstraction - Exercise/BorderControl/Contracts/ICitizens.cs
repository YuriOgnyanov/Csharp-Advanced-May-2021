using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Contracts
{
    public interface ICitizens
    {
        string Name { get; }
        string Birthdate { get; }
    }
}
