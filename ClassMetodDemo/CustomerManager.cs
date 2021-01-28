using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{ 
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " "+ customer.Surname + " "+ "added!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " "+ customer.Surname + " "+ "deleted!");
        }

        public void List(Customer customer)
        {
            Console.WriteLine("************List************");
            Console.WriteLine("Customer: " + customer.Name + " " + customer.Surname);
            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Surname);
            Console.WriteLine(customer.Phone);
            Console.WriteLine(customer.Email);
            Console.WriteLine(customer.Adress);
            Console.WriteLine("****************************");
        }
    }
}
