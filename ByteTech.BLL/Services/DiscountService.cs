using ByteTech.Core.Interfaces;
using ByteTech.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.BAL.Services
{
    public class DiscountService : IDiscountService
    {
        public Task<bool> ApplyDiscountToOrderAsync(int orderId, string discountCode)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateDiscountAmount(User customer, Discount discount, Order order)
        {
            throw new NotImplementedException();
        }

        public Discount? GetBestDiscountForCustomer(User customer, Order order)
        {
            throw new NotImplementedException();
        }

        public bool isEligibleForDiscount(User customer, int discount, Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Discount?> ValidateDiscountCodeAsync(string code, int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
