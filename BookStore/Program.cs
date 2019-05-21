using System;
using System.Diagnostics;

namespace BookStore {
    internal class Program {
        public static void Main(string[] args) {
            
            Logger l = new Logger();
            
            Library library = new Library();
            
            DatabaseManagement dbm = new DatabaseManagement();

            bool running = true;

            while (running) {
                WriteLineColored("\t\t\t=== Library ===\n", ConsoleColor.Magenta);
                WriteLineColored("\t\t1. Management book", ConsoleColor.Blue);
                WriteLineColored("\t\t2. Management people", ConsoleColor.Blue);
                WriteLineColored("\t\t3. Management Database", ConsoleColor.Blue);
                WriteLineColored("\t\t4. Exit\n", ConsoleColor.Red);
                
                Console.Write("Enter choice(number): ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option) {
                    case 1:
                        ManagementBook(library);
                        break;
                    case 2:
                        ManagementPeople();
                        break;
                    case 3:
                        ManagementDB();
                        break;
                    case 4:
                        WriteLineColored("Have a good day!", ConsoleColor.Green);
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLineColored("Invalid option !!", ConsoleColor.Red);
                        break;
                }
            }
        }
        
        public static void WriteLineColored(string text, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ManagementBook(Library library) {

            bool running = true;

            while (running) {
                WriteLineColored("\t\t1. Add book", ConsoleColor.Blue);
                WriteLineColored("\t\t2. Edit book", ConsoleColor.Blue);
                WriteLineColored("\t\t3. Remove book", ConsoleColor.Blue);
                WriteLineColored("\t\t4. Return book", ConsoleColor.Blue);
                WriteLineColored("\t\t5. Search book", ConsoleColor.Blue);
                WriteLineColored("\t\t6. Print list of books", ConsoleColor.Blue);
                WriteLineColored("\t\t7. Go back\n", ConsoleColor.Yellow);

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) {
                    case 1:
                        library.AddBook();
                        break;
                    case 2:
                        library.EditBook();
                        break;
                    case 3:
                        library.RemoveBook();
                        break;
                    case 4:
                        break;
                    case 5:
                        library.SearchBook();
                        break;
                    case 6:
                        library.PrintDepositOfBook();
                        break;
                    case 7:
                        running = false;
                        break;
                    default:
                        WriteLineColored("Invalid option !!", ConsoleColor.Red);
                        running = false;
                        break;
                }
            }
        }

        public static void ManagementPeople() {
            
            bool running = true;

            while (running) {
                WriteLineColored("\t\t1. Add people", ConsoleColor.Blue);
                WriteLineColored("\t\t2. Borrow books to people", ConsoleColor.Blue);
                WriteLineColored("\t\t3. Search people", ConsoleColor.Blue);
                WriteLineColored("\t\t4. Go back\n", ConsoleColor.Yellow);

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        WriteLineColored("Invalid option !!", ConsoleColor.Red);
                        break;
                }
            }

        }

        public static void ManagementDB() {
            Process.Start(@"LibraryHistory.txt");
        }
    }
}