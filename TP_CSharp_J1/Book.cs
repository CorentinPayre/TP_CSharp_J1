using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TP_CSharp_J1
{

    public class Book
    {
        public int bookId { get; set; }
        public string author { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int rackNo { get; set; }
        public string status { get; set; }
        public string edition { get; set; }
        public DateTime dateOfPurchase { get; set; }

        public Book(int bookId, string author, string name, double price, int rackNo, string status, string edition, DateTime dateOfPurchase)
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
        public override string ToString()
        {
            return $"BookId: {this.bookId}, Author: {this.author}, Name: {this.name}, Price: {this.price}, RackNo: {this.rackNo}, Status: {this.status}, Edition: {this.edition}, DateOfPurchase: {this.dateOfPurchase.ToShortDateString()}";
        }
    }
}
