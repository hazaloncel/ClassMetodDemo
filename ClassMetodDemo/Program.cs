using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = "000001";
            customer1.Name = "Jack";
            customer1.Surname = "Dorsey";
            customer1.Phone = 5555555555;
            customer1.Email = "abc@gmail.com";
            customer1.Adress = "ABC Str. 55/5";

            Customer customer2 = new Customer();
            customer2.ID = "000002";
            customer2.Name = "Mark";
            customer2.Surname = "Zuckerberg";
            customer2.Phone = 5455454545;
            customer2.Email = "def@gmail.com";
            customer2.Adress = "DEF Str. 45/4";

            Customer customer3 = new Customer();
            customer3.ID = "000003";
            customer3.Name = "Elon";
            customer3.Surname = "Musk";
            customer3.Phone = 5055055050;
            customer3.Email = "ghi@gmail.com";
            customer3.Adress = "GHI Str. 50/5";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            
            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customer3);
            




        }
    }
}
