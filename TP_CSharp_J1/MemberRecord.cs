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
        public MemberRecord RetrieveMember(int memberId, List<MemberRecord> members)
        {
            return members.Find(m => m.memberId == memberId);
        }

        public void IncreaseBookIssued()
        {
            if (noBookIssued < maxBookLimit)
            {
                noBookIssued++;
                Console.WriteLine($"Books issued increased. Current count: {noBookIssued}");
            }
            else
            {
                Console.WriteLine("Book issue limit reached.");
            }
        }

        public void DecreaseBookIssued()
        {
            if (noBookIssued > 0)
            {
                noBookIssued--;
                Console.WriteLine($"Books issued decreased. Current count: {noBookIssued}");
            }
        }

        public void PayBill(Bill bill)
        {
            Console.WriteLine($"Bill {bill.billNo} for {bill.amount} paid by member {memberId}.");
        }

        public override string ToString()
        {
            return $"Member Id: {this.memberId}, Type: {this.type}, Date Of Membership: {this.dateOfMembership.ToShortDateString()}, No Of Books Issued: {this.noBookIssued}, Max Book Limit: {this.maxBookLimit}, Name: {this.name}, Address: {this.address}, Phone No: {this.phoneNo}";
        }
    }
}
