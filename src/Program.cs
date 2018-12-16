using System;
using CoffeeDealer.Abstract;
using CoffeeDealer.Adapters;
using CoffeeDealer.Concrete;
using CoffeeDealer.Entities;

namespace CoffeeDealer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var newCustomer = new Customer
            {
                Id = Guid.NewGuid(),
                Name = "Kerem",
                LastName = "Gorkem",
                BirthDate = new DateTime(1991, 7 , 14),
                NationalityId = "1"
            };

            var newProduct = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Americano"
            };

            BaseCustomerManager manager = new StarbucksCustomerManager(new MernisServiceFakeAdapter());
            manager.Save(newCustomer);

            Console.WriteLine("");

            var productManager = new StarbucksPurchaseManager(new StarbucksStarLoyaltyManager(newCustomer));
            productManager.Purchase(newProduct, newCustomer);

            Console.ReadKey();
        }
    }
}
