using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvintetten
{
    public class Instrument
    {
        public string Description { get; set; }

        public Instrument(string description)
        {
            Description = description;
        }

        public override string ToString()
        {
            return $"Description: {Description}";
        }
    }
}
