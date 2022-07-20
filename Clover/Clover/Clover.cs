using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clover
{
    public class Clover
    {
        private Settings.Target target { get; set; }
        private Credentials.Manager manager { get; set; }

        public Clover(Settings.Target target)
        {
            this.target = target;
            manager = new Credentials.Manager(target.firstname, target.lastname, target.birthdate);

            firstname();
            lastname();
            cumulate();
        }

        private void firstname()
        {
            target.firstname.upperlow();
            target.firstname.binding();
        }

        private void lastname()
        {
            target.lastname.upperlow();
            target.lastname.binding();
        }

        private void cumulate()
        {
            manager.generate();
        }

        public List<string> dump()
        {
            List<string> passwords = new List<string>();

            concat(passwords, target.firstname.passwords);
            concat(passwords, target.lastname.passwords);
            concat(passwords, manager.passwords);
            concat(passwords, target.birthdate.passwords);

            return (passwords);
        }

        public void write()
        {
            List<string> passwords = new List<string>();

            concat(passwords, target.firstname.passwords);
            concat(passwords, target.lastname.passwords);
            concat(passwords, manager.passwords);
            concat(passwords, target.birthdate.passwords);

            File.WriteAllLines("passwords.txt", passwords.ToArray());
        }

        private List<string> concat(List<string> previous, List<string> to_add)
        {
            foreach (string s in to_add)
            {
                if (previous.Contains(s) == false)
                {
                    previous.Add(s);
                }
            }

            return (previous);
        }
    }
}
