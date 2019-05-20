using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml;

namespace BookStore {
    public class Book {

        private int bookID;
        private String title;
        private String author;
        private bool isTaken;
        private int numberPerBook;
        private List<HoldRequest> holdRequests;

        private static int currentId = 0;

        public Book(String title, String author, int numberPerBook) {
            currentId++;
            bookID = currentId;
            this.title = title;
            this.author = author;
            isTaken = false;
            this.numberPerBook = numberPerBook;
            holdRequests = new List<HoldRequest>();
        }

        public int NumberPerBook {
            get => numberPerBook;
            set => numberPerBook = value;
        }

        public string Title {
            get => title;
            set => title = value;
        }

        public string Author {
            get => author;
            set => author = value;
        }

        public int BookId => bookID;
        
        public void addHoldRequest(HoldRequest r) {
            holdRequests.Add(r);
        }

        public void removeHoldRequest() {
            if (!isEmpty<HoldRequest>(holdRequests)) {
                holdRequests.RemoveAt(0);
            }
        }
        
        //    Kind of extension method
        public static bool isEmpty<T>(IEnumerable<T> enumerable) {
            if (enumerable == null)
                return true;

            var collection = enumerable as Collection<T>;
            if (collection != null)
                return collection.Count < 1;
            return !enumerable.Any();
        }

        public void EditBook(String name, String author) {
            Title = name;
            Author = author;
        }

        public override string ToString() {
            return "Unique id: " + bookID + ", Title: " + title + ", author: " + author + ", no of this book: " + numberPerBook;
        }
    }
}