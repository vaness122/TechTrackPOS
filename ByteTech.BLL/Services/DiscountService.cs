using ByteTech.Core.Interfaces;
using ByteTech.Core.Models;
using ByteTech.Infrastructure.Data; 
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ByteTech.BAL.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly ApplicationDbContext _context;

        public DiscountService(ApplicationDbContext context)
        {
            _context = context;
        }

  
        public async Task<IEnumerable<Discount>> GetAllDiscountsAsync()
            => await _context.Discounts.ToListAsync();

        public async Task<Discount?> GetDiscountByIdAsync(int id)
            => await _context.Discounts.FindAsync(id);

        public async Task<bool> CreateDiscountAsync(Discount discount)
        {
            var exists = await _context.Discounts.AnyAsync(d => d.Code == discount.Code);
            if (exists)
            {
                return false;
            }
            _context.Discounts.Add(discount);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateDiscountAsync(Discount discount)
        {
            _context.Entry(discount).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteDiscountAsync(int id)
        {
            var discount = await _context.Discounts.FindAsync(id);
            if (discount == null) return false;
            _context.Discounts.Remove(discount);
            return await _context.SaveChangesAsync() > 0;
        }

        
        public bool isEligibleForDiscount(User customer, int discount, Order order) => true;
        public decimal CalculateDiscountAmount(User customer, Discount discount, Order order)
        {
            if (discount == null || !discount.IsActive) return 0;
            decimal discountAmount = 0;

            if (discount.DiscountType == ByteTech.Shared.Enum.DiscountType.Percentage)
            {
                discountAmount = order.SubTotal * (discount.Value / 100);
            }
            else
            {
                discountAmount = discount.Value;
            }
            if (discount.MaximumDiscountAmount.HasValue && discountAmount > discount.MaximumDiscountAmount.Value)
            {
                discountAmount = discount.MaximumDiscountAmount.Value;
            }
            return Math.Min(discountAmount, order.SubTotal);
        }
        public Discount? GetBestDiscountForCustomer(User customer, Order order) => null;
        public async Task<bool> ApplyDiscountToOrderAsync(int orderId, string discountCode) => true;
        public async Task<Discount?> ValidateDiscountCodeAsync(string code, int customerId)
            => await _context.Discounts.FirstOrDefaultAsync(d => d.Code == code);
    }
}