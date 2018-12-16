using CoffeeDealer.Entities;

namespace CoffeeDealer.Abstract
{
    public interface IPurchaseService
    {
        void Purchase(Product product, Customer customer);
    }
}