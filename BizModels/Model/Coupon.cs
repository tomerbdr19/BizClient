using System;
namespace BizModels.Model
{
    public class Coupon
    {
        public string Id { get; set; }
        public Business Business { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
        public CouponStatus Status { get; set; }
    }

    public enum CouponStatus
    {
        expired,
        redeemed,
        available
    }
}

