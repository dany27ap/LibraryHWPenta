using System;
using System.Collections;
using System.Collections.Generic;

namespace BookStore {
    public class Library {
        
        private String name;
        private List<Person> persons;
        private List<Book> stockBooks;

        private List<Loan> loans;

        private static Library obj;

        public static Library getInstance() {
            
            if(obj == null)
                obj = new Library();
            return obj;
        }

        public Library() {
            name = "My Libray";
            persons = new List<Person>();
            stockBooks = new List<Book>();
            loans = new List<Loan>();
        }

        public string Name => name;

        public List<Person> Persons => persons;

        public List<Book> StockBooks => stockBooks;

        public List<Loan> Loans => loans;

        public void AddBorrower(Borrower b) => persons.Add(b);
        public void AddLoans(Loan l) => loans.Add(l);
        public void AddBook(Book b) => stockBooks.Add(b);

        public void AddBook() {
            Console.Write("Title: ");
            String name = Console.ReadLine();
            
            Console.Write("Author: ");
            String author = Console.ReadLine();
            
            Console.Write("Quantity of this book: ");
            int no = Convert.ToInt32(Console.ReadLine());
            
            stockBooks.Add(new Book(name, author, no));

        }

        public void RemoveBook() {
            Console.WriteLine("Use id for delete a book");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var b in stockBooks) {
                if (b.BookId == id) {
                    stockBooks.Remove(b);
                }
            }
        }


        public Borrower SearchPeople(int id) {
            foreach (var p in persons) {
                if (p.PersonalId == id)
                    return (Borrower) p;
            }

            Program.WriteLineColored("This id doesn't exit in list of persons !!!", ConsoleColor.Red);
            return null;   
        }

        public void SearchBook() {

            int id = -1;
            int option;
            String name = "", author = "";
            

            while (true) {
                Program.WriteLineColored("0. ID || 1. Name || 2. Author", ConsoleColor.Yellow);
                option = Convert.ToInt32(Console.ReadLine());
                if(option == 0 || option == 1 || option == 2)
                    break;
                Program.WriteLineColored("Wrong choice", ConsoleColor.Red);
            }

            if (option == 0) {
                Program.WriteLineColored("Enter id: ", ConsoleColor.Cyan);
                id = Convert.ToInt32(Console.ReadLine());
            }
            if (option == 1) {
                Program.WriteLineColored("Enter title: ", ConsoleColor.Cyan);
                name = Convert.ToString(Console.ReadLine());
            }
            if (option == 2) {
                Program.WriteLineColored("Enter author && title: ", ConsoleColor.Cyan);
                author = Convert.ToString(Console.ReadLine());
                name = Convert.ToString(Console.ReadLine());
            }
            
            foreach (var b in stockBooks) {
                if (b.Title.Equals(name) || b.BookId == id || b.Author.Equals(author)) {
                    Program.WriteLineColored("Successfully search \n" + b, ConsoleColor.Green);
                }
                else {
                    Program.WriteLineColored(name + " doesn't exit in list of books !!!", ConsoleColor.Red);
                }
            }
            
        }

        public void EditBook() {
            Program.WriteLineColored("Enter id: ", ConsoleColor.Black);
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var b in stockBooks) {
                if (b.BookId == id) {
                    
                    Console.Write("Title: ");
                    String name = Console.ReadLine();
            
                    Console.Write("Author: ");
                    String author = Console.ReadLine();
            
                    Console.Write("Quantity of this book: ");
                    int no = Convert.ToInt32(Console.ReadLine());

                    b.Title = name;
                    b.Author = author;
                    b.NumberPerBook = no;
                    
                }
            }
        }

        public void PrintDepositOfBook() {
            if (!Book.isEmpty(stockBooks)) {
                foreach (var b in stockBooks) {
                    Program.WriteLineColored(b.ToString(), ConsoleColor.Green);
                }
            }
            else {
                Program.WriteLineColored("Zero books in deposit", ConsoleColor.Red);
            }
        }

        public void BringNewBook(String title, String author, int quantity) {
            stockBooks.Add(new Book(title, author, quantity));
            Program.WriteLineColored("Book: " + title + " bring with successfully.", ConsoleColor.Green);
        }
    }
}