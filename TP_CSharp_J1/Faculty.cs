using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    internal class Faculty : MemberRecord
    {
        public string department { get; set; }

        public Faculty(int memberId, string type, DateTime dateOfMembership, int noBookIssued, int maxBookLimit, string name, string address, string phoneNo, string department)
            : base(memberId, type, dateOfMembership, noBookIssued, maxBookLimit, name, address, phoneNo)
        {
            this.department = department;
        }

        public override string ToString()
        {
            return base.ToString() + $", Department: {this.department}";
        }
    }
}
