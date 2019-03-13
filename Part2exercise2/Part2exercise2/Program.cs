using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Sam", "sm487", "Password1", "Credit Card");
            
            p1.AddToCart(123, "Shoes");
            p1.AddToCart(5423, "Hat");

            List<Array> items = new List<Array>();
            foreach(string x in p1.GetItems())
            {
                string[] words = x.Split(':');
                items.Add(words);
                Console.WriteLine("-----ID: " + words[0] + "-----");
                Console.WriteLine("Name: " + words[1]);
            }
            Console.ReadLine();
        }
    }

    public class Person
    {
        public static int counter = 0;
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PaymentMethod { get; set; }
        public List<Item> ShoppingCart { get; set; }
        


        public Person(string name, string username, string password, string paymentmethod)
        {
            Name = name;
            UserName = username;
            Password = password;
            PaymentMethod = paymentmethod;
            counter++;
        }

        public void AddToCart(int id, string name)
        {
            if (ShoppingCart == null)
            {
                ShoppingCart = new List<Item>();
            }
            ShoppingCart.Add(new Item(id, name));
        }
        public List<string> GetItems()
        {
            List<string> items = new List<string>();
            foreach (Item x in ShoppingCart)
            {
                items.Add(x.ID + ":" + x.Name);
            }
            return items;
        }
    }

    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Item(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
