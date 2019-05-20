using System;

namespace BookStore {
    public class Loan {

        private Borrower borrower;
        private Book book;

        private DateTime takenDate;
        private DateTime returnDate;
//        private int maxLoan;

        public Loan(Borrower borrower, Book book, DateTime takenDate, DateTime returnDate) {
            this.borrower = borrower;
            this.book = book;
            this.takenDate = takenDate;
            this.returnDate = returnDate;
        }

        public void extendPeriodLoan(DateTime eTime) {
            returnDate = eTime;
            
            Console.WriteLine("\nDeadline was extended for: " + book.Title + " until: " + returnDate);
        }
        

    }
}