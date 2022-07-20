using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clover.Settings
{
    public class Binds
    {
        List<Modules.Bind> binds = new List<Modules.Bind>()
        {
            new Modules.Bind("a", new List<string>() { "@", "4" }),
            new Modules.Bind("b", new List<string>() { "8" }),
            new Modules.Bind("e", new List<string>() { "3" })
        };

        public bool contains(string letter)
        {
            foreach (Modules.Bind bind in binds)
            {
                if (bind.key == letter)
                {
                    return (true);
                }
            }

            return (false);
        }

        public List<string> get(string letter)
        {
            foreach (Modules.Bind bind in binds)
            {
                if (bind.key == letter)
                {
                    return (bind.values);
                }
            }

            return (null);
        }
    }
}
