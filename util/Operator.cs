using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerGui
{
    class Operator
    {
        public string uuid { get; set; }
        public string name { get; set; }
        public string level { get; set; }
        public bool bypassesPlayerLimit { get; set; }
    }
}
