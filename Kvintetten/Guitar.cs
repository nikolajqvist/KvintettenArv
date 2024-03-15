using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvintetten
{
    internal class Guitar : Strygeinstrument
    {
        public Guitar(string description, int stringCount) : base(description, stringCount)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
