using System;
using CoffeeDealer.Abstract;

namespace CoffeeDealer.Entities
{
    public class Customer : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string NationalityId { get; set; }
    }
}