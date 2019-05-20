using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml.Xsl.Runtime;

namespace BookStore {
    internal class Program {
        public static void Main(string[] args) {
            
            Logger l = new Logger();

            bool running = true;

            while (running) {
                WriteLineColored("\t\t\t=== Library ===\n", ConsoleColor.Magenta);
                WriteLineColored("\t\t1.Management book", ConsoleColor.Blue);
                WriteLineColored("\t\t2.Management people", ConsoleColor.Blue);
                WriteLineColored("\t\t3.Management History", ConsoleColor.Blue);
                WriteLineColored("\t\t4.Exit\n", ConsoleColor.Red);
                
                Console.Write("Enter choice: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option) {
                    case 1:
                        l.WriteToLog("ceva");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        WriteLineColored("Have a good day!", ConsoleColor.Green);
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
        
        public static void WriteLineColored(string text, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}