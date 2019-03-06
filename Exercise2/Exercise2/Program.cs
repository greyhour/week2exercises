using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfClients = 5;
            List<Employee> emp = new List<Employee>();

            int counter = 0;
            do
            {
                Console.WriteLine("-----Client " + (counter+1) + "-----");
                Console.Write("Please enter the Full Name: ");
                string name = Console.ReadLine();
                Console.Write("Please enter " + name + "'s phone address: ");
                long phone = Convert.ToInt64(Console.ReadLine());
                Console.Write("Please enter " + name + "'s email address: ");
                string email = Console.ReadLine();
                Console.Write("Please enter " + name + "'s IRD number: ");
                string ird = Convert.ToString(Console.ReadLine());
                Console.Write("Please enter " + name + "'s Bank account number: ");
                long bankaccount = Convert.ToInt64(Console.ReadLine());
                Console.Write("Please enter " + name + "'s new User name: ");
                string username = Convert.ToString(Console.ReadLine());
                Console.Write("Please enter " + name + "'s new Password: ");
                string password = Convert.ToString(Console.ReadLine());
                counter++;

                emp.Add(new Employee(name, phone, email, ird, bankaccount, username, password));

                Console.Clear();
            } while (counter < numberOfClients);

            personInfo(emp).ForEach(Console.WriteLine);
            Console.ReadLine();
        }
        private static List<string> personInfo(List<Employee> emp)
        {
            List<string> info = new List<string>();
            foreach (Employee x in emp)
            {
                info.Add("-----Name: " + x.Name + "-----");
                info.Add("Phone: " + x.Phone);
                info.Add("Email: " + x.Email);
                info.Add("IRD: " + x.returnPrivateDataIRD());
                info.Add("Bank Account: " + x.returnPrivateDataBankAccount());
                info.Add("Username: " + x.Username);
                info.Add("Password: " + x.Password);
            }
            return info;
        }
    }

    class Employee
    {
        internal string Name { get; set; }
        internal long Phone { get; set; }
        internal string Email { get; set; }
        internal string IRD { private get; set; }
        internal long BankAccount { private get; set; }
        internal string Username { get; set; }
        internal string Password { get; set; }

        internal string returnPrivateDataIRD()
        {
            return this.IRD;
        }
        internal long returnPrivateDataBankAccount()
        {
            return this.BankAccount;
        }

        public Employee (string name, long phone, string email, string ird, long bankaccount, string username, string password)
        {
            Name = name;
            Phone = phone;
            Email = email;
            IRD = ird;
            BankAccount = bankaccount;
            Username = username;
            Password = password;
        }
    }
}
