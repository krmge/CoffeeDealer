using CoffeeDealer.Abstract;
using CoffeeDealer.Entities;

namespace CoffeeDealer.Concrete
{
    public class StarbucksPurchaseManager : BasePurchaseManager
    {
        private readonly IStarbucksStarLoyalty _starbucksStarLoyalty;

        public StarbucksPurchaseManager(IStarbucksStarLoyalty starbucksStarLoyalty)
        {
            _starbucksStarLoyalty = starbucksStarLoyalty;
        }

        public override void Purchase(Product product, Customer customer)
        {
            base.Purchase(product, customer);

            _starbucksStarLoyalty.AddStar();
        }
    }
}
