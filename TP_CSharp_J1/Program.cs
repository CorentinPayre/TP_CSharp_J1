using TP_CSharp_J1;

public class Program
{
    public static void Main()
    {
        Book book = new Book(1, "J.K. Rowling", "Harry Potter", 39.99, 5, "Available", "1st Edition", DateTime.Now);
        Console.WriteLine(book);

        Journal journal = new Journal(2, "John Doe", "Science Today", 19.99, 10, "Checked Out", "5th Edition", DateTime.Now, "Daily");
        Console.WriteLine(journal);

        Magazine magazine = new Magazine(3, "Jane Smith", "Tech World", 9.99, 15, "Available", "3rd Edition", DateTime.Now, "Software Development");
        Console.WriteLine(magazine);

        StudyBook studyBook = new StudyBook(4, "Albert Einstein", "Relativity", 49.99, 7, "Available", "10th Edition", DateTime.Now, 1921, "Physics");
        Console.WriteLine(studyBook);

        Librarian librarian = new Librarian("Alice", "password123");
        Console.WriteLine(librarian);

        Transaction transaction = new Transaction(1, 101, 1, DateTime.Now, DateTime.Now.AddDays(14));
        Console.WriteLine(transaction);

        Bill bill = new Bill(1, DateTime.Now, 101, 100.50);
        Console.WriteLine(bill);

        Student student = new Student(101, "Student", DateTime.Now, 2, 5, "John Doe", "123 Main St", "555-1234", "10th Grade");
        Console.WriteLine(student);

        Faculty faculty = new Faculty(102, "Faculty", DateTime.Now, 3, 10, "Dr. Smith", "456 College Ave", "555-5678", "Computer Science");
        Console.WriteLine(faculty);
    }
}
