using System;

namespace BookStore {
    public class Person {
        protected int personalId;
        protected String name;
        protected String address;

        private static int currentId = 0;

        public Person(String name, String address) {
            currentId++;
            personalId = currentId;
            this.name = name;
            this.address = address;
        }

        public void print() {
            Console.WriteLine("Unique id: " + personalId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
        }

        public int PersonalId => personalId;

        public string Name => name;

        public string Address => address;
    }
}