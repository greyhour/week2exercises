using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CreditCard> CreditCards = new List<CreditCard>();
            int counter = 0;
            Boolean exit = false;
            do
            {
                Console.WriteLine("Would you like to create a CreditCard? (y/n):");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "y":
                        Console.Clear();

                        Console.WriteLine("Please enter the Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please enter the Credit Card Number: ");
                        long creditcard = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Please enter the CSC: ");
                        int csc = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the expiry Date: ");
                        string date = Console.ReadLine();

                        CreditCards.Add(new CreditCard(name, creditcard, csc, date));
                        counter++;
                        break;
                    case "n":
                        exit = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine(input + " is not a recognized input!");
                        break;
                }
            } while (counter < 5 && exit == false);

            Console.Clear();
            foreach (CreditCard x in CreditCards)
            {
                Console.Write("Name: " + x.Name + ", ");
                Console.Write(", Date: " + x.Date);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    class CreditCard
    {
        internal string Name { get; set; }
        internal long CreditNum { private get; set; }
        internal int CSC { private get; set; }
        internal string Date { get; set; }

        internal string DisplayPrivateData()
        {
            return "Credit Card Number: " + CreditNum + ", CSC: " + CSC;
        }

        public CreditCard(string name, long creditcard, int csc, string date)
        {
            Name = name;
            CreditNum = creditcard;
            CSC = csc;
            Date = date;
        }
    }
}
