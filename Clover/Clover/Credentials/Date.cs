using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clover.Credentials
{
    public class Date
    {
        public string[] date { get; set; }
        public List<string> passwords = new List<string>();

        public Date(string[] date)
        {
            this.date = date;
        }
    }
}
