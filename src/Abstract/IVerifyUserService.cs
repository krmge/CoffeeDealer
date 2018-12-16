using CoffeeDealer.Entities;

namespace CoffeeDealer.Abstract
{
    public interface IVerifyUserService
    {
        bool IsRealCustomer(Customer customer);
    }
}