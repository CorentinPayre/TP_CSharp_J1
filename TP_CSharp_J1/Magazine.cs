using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    internal class Magazine : Book
    {
        public string subject;
        public Magazine(int bookId, string author, string name, double price, int rackNo, string status, string edition, DateTime dateOfPurchase, string subject) : base(bookId, author, name, price, rackNo, status, edition, dateOfPurchase)
        {
        }
    }
}
