using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    internal class Student : MemberRecord
    {
        public string grade { get; set; }

        public Student(int memberId, string type, DateTime dateOfMembership, int noBookIssued, int maxBookLimit, string name, string address, string phoneNo, string grade)
            : base(memberId, type, dateOfMembership, noBookIssued, maxBookLimit, name, address, phoneNo)
        {
            this.grade = grade;
        }

        public override string ToString()
        {
            return base.ToString() + $", Grade: {this.grade}";
        }
    }
}
