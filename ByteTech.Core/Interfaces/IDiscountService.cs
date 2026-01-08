using ByteTech.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Core.Interfaces
{
   public interface IDiscountService
    {
        Task<IEnumerable<Discount>> GetAllDiscountsAsync();
        Task<Discount?> GetDiscountByIdAsync(int Id);
        Task<bool> CreateDiscountAsync(Discount discount);
        Task<bool> UpdateDiscountAsync(Discount discount);
        Task<bool> DeleteDiscountAsync(int Id);



        bool isEligibleForDiscount(User customer, int discount, Order order);
        decimal CalculateDiscountAmount(User customer, Discount discount, Order order);
        Discount? GetBestDiscountForCustomer(User customer, Order order);
        Task<bool> ApplyDiscountToOrderAsync(int orderId, string discountCode);
        Task<Discount?> ValidateDiscountCodeAsync(string code, int customerId);
    }
}
