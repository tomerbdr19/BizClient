using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizService.Services
{
    public class CouponService : ServiceBase
    {
        protected override string Path => "coupon";


        async public Task<List<Coupon>> GetBusinessCoupons(string businessId, int page = 0)
        {
            var coupons = await GetAsync<List<Coupon>>(Path, new Dictionary<string, string> { { "coupon", businessId } });
            return coupons;
        }
    }
}

