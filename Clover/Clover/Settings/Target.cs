using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clover.Settings
{
    public class Target
    {
        public Credentials.Name firstname { get; set; }
        public Credentials.Name lastname { get; set; }
        public Credentials.Date birthdate { get; set; }
    }
}
