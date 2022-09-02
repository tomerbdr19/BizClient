using BizModels.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizService.Services
{
    public class DiscountService : ServiceBase
    {
        protected override string Path => "discount";

        public async Task<List<Discount>> GetDiscounts(string business)
        {
            var discounts = await GetAsync<List<Discount>>($"{Path}", new Dictionary<string, string> { { "business", business } });
            return discounts;
        }

        public async Task<Discount> DeleteDiscount(string business, string discount)
        {
            var discounts = await PostAsync<Discount>($"{Path}/delete", new { business, discount });
            return discounts;
        }

        public async Task<Discount> ExtendDiscount(string business, string discount, DateTime expiredAt)
        {
            var discounts = await PostAsync<Discount>($"{Path}/extend", new { business, discount, expiredAt });
            return discounts;
        }

        public async Task<Discount> ShareDiscount(string business, string discount)
        {
            var discounts = await PostAsync<Discount>($"{Path}/share", new { business, discount });
            return discounts;
        }
    }
}

