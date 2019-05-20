using System;

namespace BookStore {
    public class HoldRequest {
        private Borrower borrower { get; }
        private Book book { get; }
        private DateTime requestDate { get; }

        public HoldRequest(Borrower borrower, Book book, DateTime requestDate) {
            this.borrower = borrower;
            this.book = book;
            this.requestDate = requestDate;
        }

        public override string ToString() {
            return book.Title + "\t\t\t" + borrower.Name + "\t\t\t" + requestDate + "\n";
        }

    }
}