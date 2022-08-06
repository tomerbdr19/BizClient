using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizService.Services
{
    public class CouponService : ServiceBase
    {
        protected override string Path => "coupon";

        public async Task<List<Coupon>> GetUserCoupons(string userId)
        {
            var coupons = await GetAsync<List<Coupon>>($"{Path}", new Dictionary<string, string> { { "user", userId } });
            return coupons;
        }

        public async Task<List<Coupon>> GetRedeemCode(string couponId)
        {
            var coupons = await GetAsync<List<Coupon>>($"{Path}/redeem-code", new Dictionary<string, string> { { "coupon", couponId } });
            return coupons;
        }

        public async Task<List<Coupon>> RedeemCoupon(string redeemCode)
        {
            throw new Exception("not implemented");
        }
    }
}

