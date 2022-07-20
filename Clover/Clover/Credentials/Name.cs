using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clover.Credentials
{
    public class Name
    {
        private Settings.Binds binds = new Settings.Binds();
        public List<string> passwords = new List<string>();
        private string name { get; set; }

        public Name(string value)
        {
            this.name = value;
        }
            
        public void upperlow()
        {
            passwords.Add(name);
            for (int i = 0; i < name.Length; i++)
            {
                passwords.Add(up_at(name, i));
            }
            passwords.Add(up_all(name, 1));
            passwords.Add(up_all(name, 2));
        }

        public void binding()
        {
            string buffer = name;

            for (int i = 0; i < name.Length; i++)
            {
                if (binds.contains($"{name[i]}") == true)
                {
                    foreach (string bind in binds.get($"{name[i]}"))
                    {
                        buffer = name.Replace($"{name[i]}", bind);
                        if (passwords.Contains(buffer) == false)
                        {
                            passwords.Add(buffer);
                        }
                    }
                }
            }
        }

        private string up_all(string name, int odd)
        {
            char[] copy = name.ToArray();

            for (int i = 0; (i + odd) < copy.Length; i += odd)
            {
                copy[i] = (char)(copy[i] - 32);
            }

            return (enumerate(copy));
        }

        private string up_at(string name, int index)
        {
            char[] copy = name.ToArray();

            copy[index] = (char)(copy[index] - 32);

            return (enumerate(copy));
        }

        private string enumerate(char[] data)
        {
            string result = "";

            foreach (char c in data)
            {
                result += c;
            }

            return (result);
        }
    }
}
