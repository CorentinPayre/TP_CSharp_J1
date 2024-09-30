using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{

    internal class Book
    {
        public int bookId { get; set; }
        public string author { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string rackNo { get; set; }
        public string status { get; set; }
        public string edition { get; set; }
        public DateTime dateOfPurchase { get; set; }

        public Book(int bookId, string author, string name, decimal price, string rackNo, string status, string edition, DateTime dateOfPurchase)
        {
            this.bookId = bookId;
            this.author = author;
            this.name = name;
            this.price = price;
            this.rackNo = rackNo;
            this.status = status;
            this.edition = edition;
            this.dateOfPurchase = dateOfPurchase;
        }
    }
}
