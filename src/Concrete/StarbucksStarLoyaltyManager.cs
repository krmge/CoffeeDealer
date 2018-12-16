using System;
using CoffeeDealer.Abstract;
using CoffeeDealer.Entities;

namespace CoffeeDealer.Concrete
{
    public class StarbucksStarLoyaltyManager : IStarbucksStarLoyalty
    {
        private readonly Customer _customer;

        public StarbucksStarLoyaltyManager(Customer customer)
        {
            _customer = customer;
        }

        public void AddStar()
        {
            var starsOfCustomer = new Star().FindByCustomerId(_customer.Id);

            if (starsOfCustomer.Count <= 15)
                starsOfCustomer.Count++;

            Console.WriteLine($"{_customer.Name} {_customer.LastName} now has {starsOfCustomer.Count} / 15");
        }

        public void GiveFreeCoffee()
        {
            throw new NotImplementedException();
        }
    }
}
