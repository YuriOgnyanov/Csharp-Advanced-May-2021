using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Contracts
{
    public interface IRobotable
    {
        public string Model { get; }
        public string Id { get; }
    }
}
