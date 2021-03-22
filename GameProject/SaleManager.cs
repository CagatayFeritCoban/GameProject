using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager
    {
        public void Sale(Customer customer, Game game)
        {
            Console.WriteLine("Customer: " + customer.FirstName + " Game: " + game.GameName);
        }
    }
}
