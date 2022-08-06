using System;
namespace BizModels.Model
{
    public class Coupon
    {
        public string Id { get; set; }
        public Discount Discount { get; set; }
        public User User { get; set; }
        public string RedeemCode { get; set; }
        public bool IsRedeemed { get; set; }
        public bool IsAvailable => DateTime.Now < Discount.ExpiredAt && !IsRedeemed;
    }
}

