using BizModels.Model;
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

        public async Task<string> GetRedeemCode(string couponId)
        {
            var coupons = await GetAsync<string>($"{Path}/redeem-qr-code", new Dictionary<string, string> { { "coupon", couponId } });
            return coupons;
        }
        public async Task<Coupon> RedeemCoupon(string redeemCode, string businessId)
        {
            var coupons = await PostAsync<Coupon>($"{Path}/redeem", new { redeemCode, business = businessId });
            return coupons;
        }

        public async Task<Coupon> CreateCoupon(string user, string discount)
        {
            var coupon = await PostAsync<Coupon>($"{Path}", new { user, discount });
            return coupon;
        }
    }
}

