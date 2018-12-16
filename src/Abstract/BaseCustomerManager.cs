using System;
using CoffeeDealer.Entities;

namespace CoffeeDealer.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.LastName} is saved.");
        }
    }
}
