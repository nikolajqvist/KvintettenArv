using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvintetten
{
    public class Drum : Instrument
    {
        public Drum(string description) : base(description)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
