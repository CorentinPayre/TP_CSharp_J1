using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    public class Librarian
    {
        public string name;
        public string password;

        public Librarian(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public override string ToString()
        {
            return $"Librarian Name: {this.name}, Password : {this.password}";
        }
    }
}
