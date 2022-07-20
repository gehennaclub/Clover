using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clover.Credentials
{
    public class Manager
    {
        private Name firstname { get; set; }
        private Name lastname { get; set; }
        private Date date { get; set; }
        public List<string> passwords = new List<string>();

        public Manager(Credentials.Name firstname, Credentials.Name lastname, Date date)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.date = date;
        }

        public void generate()
        {
            generate_first_last();
            generate_last_first();
            generate_first_last_date();
            generate_last_first_date();
        }

        public void generate_last_first()
        {
            foreach (string last in lastname.passwords)
            {
                foreach (string first in firstname.passwords)
                {
                    foreach (string sep in Settings.Separators.list)
                    {
                        passwords.Add($"{last}{sep}{first}");
                    }
                }
            }
        }

        public void generate_first_last()
        {
            foreach (string last in lastname.passwords)
            {
                foreach (string first in firstname.passwords)
                {
                    foreach (string sep in Settings.Separators.list)
                    {
                        passwords.Add($"{first}{sep}{last}");
                    }
                }
            }
        }

        public void generate_first_last_date()
        {
            foreach (string last in lastname.passwords)
            {
                foreach (string first in firstname.passwords)
                {
                    foreach (string sep in Settings.Separators.list)
                    {
                        passwords.Add($"{first}{sep}{last}{date.date[0]}");
                        passwords.Add($"{first}{sep}{last}{date.date[1]}");
                        passwords.Add($"{first}{sep}{last}{date.date[2]}");
                    }
                }
            }
        }

        public void generate_last_first_date()
        {
            foreach (string last in lastname.passwords)
            {
                foreach (string first in firstname.passwords)
                {
                    foreach (string sep in Settings.Separators.list)
                    {
                        passwords.Add($"{last}{sep}{first}{date.date[0]}");
                        passwords.Add($"{last}{sep}{first}{date.date[1]}");
                        passwords.Add($"{last}{sep}{first}{date.date[2]}");
                    }
                }
            }
        }
    }
}
