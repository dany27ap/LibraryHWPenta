using System.Collections.Generic;

namespace BookStore {
    public class Borrower : Person {
        private List<Book> books;
        
        public Borrower(string name, string address) : base(name, address) {
            this.books = new List<Book>();
        }
    }
}