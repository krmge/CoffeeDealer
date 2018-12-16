using System;
using CoffeeDealer.Abstract;

namespace CoffeeDealer.Entities
{
    public class Product : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
