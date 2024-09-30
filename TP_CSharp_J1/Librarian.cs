using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    public class Librarian
    {
        public string name;
        public string password;

        public Librarian(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public Book SearchBook(int bookId, List<Book> books)
        {
            return books.Find(book => book.bookId == bookId);
        }

        public bool VerifyMember(int memberId, List<MemberRecord> members)
        {
            return members.Exists(member => member.memberId == memberId);
        }

        public Transaction IssueBook(int bookId, int memberId, List<Book> books, List<MemberRecord> members, List<Transaction> transactions)
        {
            Book book = SearchBook(bookId, books);
            if (book != null && VerifyMember(memberId, members) && book.status == "Available")
            {
                book.UpdateStatus("Issued");
                var newTransaction = new Transaction(transactions.Count + 1, memberId, bookId, DateTime.Now, DateTime.Now.AddDays(14));
                transactions.Add(newTransaction);
                Console.WriteLine("Book issued successfully.");
                return newTransaction;
            }
            Console.WriteLine("Book cannot be issued.");
            return null;
        }

        public double CalculateFine(DateTime dueDate)
        {
            var overdueDays = (DateTime.Now - dueDate).Days;
            return overdueDays > 0 ? overdueDays * 1.0 : 0;
        }

        public Bill CreateBill(int memberId, double amount, List<Bill> bills)
        {
            var newBill = new Bill(bills.Count + 1, DateTime.Now, memberId, amount);
            bills.Add(newBill);
            Console.WriteLine("Bill created.");
            return newBill;
        }

        public void ReturnBook(int bookId, List<Book> books, List<Transaction> transactions)
        {
            var book = SearchBook(bookId, books);
            var transaction = transactions.Find(t => t.bookId == bookId);

            if (book != null && transaction != null)
            {
                book.UpdateStatus("Available");
                Console.WriteLine("Book returned successfully.");
            }
        }
        public override string ToString()
        {
            return $"Librarian Name: {this.name}, Password : {this.password}";
        }
    }
}
