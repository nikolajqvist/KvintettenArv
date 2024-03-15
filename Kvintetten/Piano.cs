using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvintetten
{
    public class Piano : Instrument
    {
        public Piano(string description) : base(description)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
