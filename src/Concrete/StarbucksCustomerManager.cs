using System;
using CoffeeDealer.Abstract;
using CoffeeDealer.Entities;

namespace CoffeeDealer.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private readonly IVerifyUserService _verifyUserService;

        public StarbucksCustomerManager(IVerifyUserService verifyUserService)
        {
            _verifyUserService = verifyUserService;
        }

        public override void Save(Customer customer)
        {
            if (_verifyUserService.IsRealCustomer(customer))
                base.Save(customer);
            else
                throw new Exception("Customer is invalid!");

        }
    }
}
