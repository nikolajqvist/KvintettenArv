using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvintetten
{
    public class Violin : Strygeinstrument
    {
        public Violin(string description, int stringCount) : base(description, stringCount)
        {
     
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
