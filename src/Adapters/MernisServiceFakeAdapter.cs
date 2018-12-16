using CoffeeDealer.Abstract;
using CoffeeDealer.Entities;

namespace CoffeeDealer.Adapters
{
    public class MernisServiceFakeAdapter : IVerifyUserService
    {
        public bool IsRealCustomer(Customer customer)
        {
            return true;
        }
    }
}
