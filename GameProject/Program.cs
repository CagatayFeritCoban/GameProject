using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.FirstName = "Çağatay";
            customer1.LastName = "Çoban";
            customer1.NationalityID = "111111111111";

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName ="Black Desert Online";
            game1.GamePrice = 18;

            Offer offer1 = new Offer();
            offer1.OfferId = 1;
            offer1.OfferCount = 1;
            offer1.OfferName = "An offer for a lucky person";
            offer1.OfferDiscount = "75%";
            
        }
    }
}
