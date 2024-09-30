using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    public class StudyBook : Book
    {
        public int publishingYear {  get; set; }
        public string subject { get; set; }
        public StudyBook(int bookId, string author, string name, double price, int rackNo, string status, string edition, DateTime dateOfPurchase, int publishingYear, string subject) : base(bookId, author, name, price, rackNo, status, edition, dateOfPurchase)
        {
            this.publishingYear = publishingYear;
            this.subject = subject;
        }
        public override string ToString()
        {
            return base.ToString() + $", Publishing Year : {this.publishingYear}, Subject: {this.subject}";
        }
    }
}
