using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Contracts
{
    public interface IBuyer
    {
        public void BuyFood();
        int Food { get; } 

    }
}
