using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    public class Bill
    {
        public int billNo { get; set; }
        public DateTime date { get; set; }
        public int memberId { get; set; }
        public double amout { get; set; }

        public Bill(int billNo, DateTime date, int memberId, double amout)
        {
            this.billNo = billNo;
            this.date = date;
            this.memberId = memberId;
            this.amout = amout;
        }
        public override string ToString()
        {
            return $"Bill No: {this.billNo}, Date: {this.date.ToShortDateString()}, Member Id: {this.memberId}, Amout: {this.amout}";
        }
    }
}
