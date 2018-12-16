using CoffeeDealer.Abstract;
using CoffeeDealer.Entities;
using System;

namespace CoffeeDealer.Adapters
{
    public class MernisServiceAdapter : IVerifyUserService
    {
        public bool IsRealCustomer(Customer customer)
        {
            var client = new MernisService.KPSPublicSoapClient();

            var response = client.TCKimlikNoDogrula(
                Convert.ToInt64(customer.NationalityId),
                customer.Name.ToUpper(),
                customer.LastName.ToUpper(),
                customer.BirthDate.Year
            );

            return response;
        }
    }
}
