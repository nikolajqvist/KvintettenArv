using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvintetten
{
    public class Strygeinstrument : Instrument
    {
        public Strygeinstrument(string description, int stringCount) : base(description)
        {
            StringCount = stringCount;
        }
        public int StringCount { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
