using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    public class MemberRecord
    {
        public int memberId { get; set; }
        public string type { get; set; }
        public DateTime dateOfMembership { get; set; }
        public int noBookIssued { get; set; }
        public int maxBookLimit { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phoneNo { get; set; }

        public MemberRecord(int memberId, string type, DateTime dateOfMembership, int noBookIssued, int maxBookLimit, string name, string address, string phoneNo)
        {
            this.memberId = memberId;
            this.type = type;
            this.dateOfMembership = dateOfMembership;
            this.noBookIssued = noBookIssued;
            this.maxBookLimit = maxBookLimit;
            this.name = name;
            this.address = address;
            this.phoneNo = phoneNo;
        }

        public override string ToString()
        {
            return $"Member Id: {this.memberId}, Type: {this.type}, Date Of Membership: {this.dateOfMembership.ToShortDateString()}, No Of Books Issued: {this.noBookIssued}, Max Book Limit: {this.maxBookLimit}, Name: {this.name}, Address: {this.address}, Phone No: {this.phoneNo}";
        }
    }
}
