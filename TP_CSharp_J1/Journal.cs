using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    public class Journal : Book
    {
        public string frequency { get; set; }
        public Journal(int bookId, string author, string name, double price, int rackNo, string status, string edition, DateTime dateOfPurchase, string frequency) : base(bookId, author, name, price, rackNo, status, edition, dateOfPurchase)
        {
            this.frequency = frequency;
        }
        public override string ToString()
        {
            return base.ToString() + $", Frequency: {this.frequency}";
        }
    }
}
