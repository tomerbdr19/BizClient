using System;
namespace BizClient.Model
{
    public class Coupon
    {
        public Coupon(string Id, string BusinessName, string BusinessImageUrl, string Description, DateTime ExpiredAt, bool IsRedeemed)
        {
            Id = this.Id;
            Description = this.Description;
            ExpiredAt = this.ExpiredAt;
            // TODO: resolve from BusinessService
            BusinessName = this.BusinessName;
            BusinessImageUrl = this.BusinessImageUrl;
            IsRedeemed = this.IsRedeemed;
        }
        public string Id { get; set; }

        public string BusinessName { get; set; }

        public string BusinessImageUrl { get; set; }

        public string Description { get; set; }

        public DateTime ExpiredAt { get; set; }

        public bool IsRedeemed { get; set; }
    }

    // TODO: move to seperate folder
    public class CouponResponse
    {
        public string Id { get; set; }

        public string BusinessId { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public DateTime ExpiredAt { get; set; }

        public bool IsRedeemed { get; set; }
    }
}

