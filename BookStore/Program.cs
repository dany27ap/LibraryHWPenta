using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Xml.Xsl.Runtime;

namespace BookStore {
    internal class Program {
        public static void Main(string[] args) {
            
            Logger l = new Logger();

            bool running = true;

            while (running) {
                WriteLineColored("\t\t\t=== Library ===\n", ConsoleColor.Magenta);
                WriteLineColored("\t\t1. Management book", ConsoleColor.Blue);
                WriteLineColored("\t\t2. Management people", ConsoleColor.Blue);
                WriteLineColored("\t\t3. Management Database", ConsoleColor.Blue);
                WriteLineColored("\t\t4. Exit\n", ConsoleColor.Red);
                
                Console.Write("Enter choice: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option) {
                    case 1:
                        ManagementBook();
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
                }
            }
        }
        
        public static void WriteLineColored(string text, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ManagementBook() {

            bool running = true;

            while (running) {
                WriteLineColored("\t\t1. Add book", ConsoleColor.Blue);
                WriteLineColored("\t\t2. Edit book", ConsoleColor.Blue);
                WriteLineColored("\t\t3. Remove book", ConsoleColor.Blue);
                WriteLineColored("\t\t4. Return book", ConsoleColor.Blue);
                WriteLineColored("\t\t5. Search book", ConsoleColor.Blue);
                WriteLineColored("\t\t6. Go back\n", ConsoleColor.Yellow);

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
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
                }
            }

        }

        public static void ManagementDB() {
            Process.Start(@"LibraryHistory.txt");
        }
    }
}