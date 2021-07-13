using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        
        public string RandomString()
        {
            Random random = new Random();

            string str = null;
            int index = random.Next(0, this.Count);
            str = this[index];
            this.RemoveAt(index);

            return str;
        }

    }
}
