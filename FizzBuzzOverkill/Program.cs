using System.Collections.Generic;

namespace fizzbuzz
{
    class Program {
        static void Main(string[] args) {
            List<Item> items = new List<Item>() { 
                new Item(3, "fizz"), 
                new Item(5, "buzz"), 
            };
        
            for (int i = 1; i <= 100; i++) {
                string message = "";
                foreach (Item item in items) {
                    if (i % item.number == 0) message += item.word;
                }
                if (message == "") {
                    message = i.ToString();
                }
                System.Console.WriteLine(message);
            };
        }
    }

    class Item {
        public int number;
        public string word;
        public Item(int number, string word) {
            this.number = number;
            this.word = word;
        }
    }
}