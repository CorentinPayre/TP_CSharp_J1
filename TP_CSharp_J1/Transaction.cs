using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    public class Transaction
    {
        public int transId { get; set; }
        public int memberId { get; set; }
        public int bookId { get; set; }
        public DateTime dateOfIssue { get; set; }
        public DateTime dueDate { get; set; }

        public Transaction(int transId, int memberId, int bookId, DateTime dateOfIssue, DateTime dueDate)
        {
            this.transId = transId;
            this.memberId = memberId;
            this.bookId = bookId;
            this.dateOfIssue = dateOfIssue;
            this.dueDate = dueDate;
        }
        public void CreateTransaction(List<Transaction> transactions)
        {
            transactions.Add(this);
            Console.WriteLine("Transaction created.");
        }

        public void DeleteTransaction(List<Transaction> transactions)
        {
            transactions.Remove(this);
            Console.WriteLine("Transaction deleted.");
        }

        public Transaction RetrieveTransaction(int transId, List<Transaction> transactions)
        {
            return transactions.Find(t => t.transId == transId);
        }
        public override string ToString()
        {
            return $"Transaction Id: {this.transId}, Member Id: {this.memberId}, Book Id: {this.bookId}, Date Of Issue: {this.dateOfIssue.ToShortDateString()}, Due Date: {this.dueDate.ToShortDateString()}";
        }
    }
}
