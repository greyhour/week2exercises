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
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PaymentMethod { get; set; }
        public ShoppingCart Cart { get; set; }


        public Customer(string name, string username, string password, string paymentmethod, ShoppingCart cart)
        {
            Name = name;
            Username = username;
            Password = password;
            PaymentMethod = paymentmethod;
            Cart = cart;
        }
    }

    class ShoppingCart
    {
        public string ItemName { get; set; }
        public int ProductCode { get; set; }
        public int ItemCost { get; set; }
        public int TotalCosts { get; set; }
    }
}
