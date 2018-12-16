using CoffeeDealer.Entities;
using System;

namespace CoffeeDealer.Abstract
{
    public abstract class BasePurchaseManager : IPurchaseService
    {
        public virtual void Purchase(Product product, Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.LastName} bought {product.Name}!");
        }
    }
}
