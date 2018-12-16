using System;

namespace CoffeeDealer.Entities
{
    public class Star
    {
        public Guid Id { get; set; }

        public short Count { get; set; }

        public Guid CustomerId { get; set; }

        public Star FindByCustomerId(Guid customerId)
        {
            return new Star
            {
                Id = Guid.NewGuid(),
                Count = 13,
                CustomerId = customerId
            };
        }
    }
}
