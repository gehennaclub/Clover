using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clover.Modules
{
    public class Bind
    {
        public string key { get; set; }
        public List<string> values { get; set; }

        public Bind(string key, List<string> values)
        {
            this.key = key;
            this.values = values;
        }
    }
}
