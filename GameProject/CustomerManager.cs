using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CustomerManager
    {
        public void AddCustomer( Customer customer)
        {
            Console.WriteLine("Customer" + customer.FirstName+"Added");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer" + customer.FirstName+"deleted");
        }
    }
}
