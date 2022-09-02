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
    }
}

