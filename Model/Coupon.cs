using System;
namespace BizClient.Model
{
    public enum CouponStatus
    {
        expired,
        redeemed,
        available
    }

    public class Coupon
    {
        public Coupon(CouponResponse response)
        {
            this.Id = response.Id;
            this.Description = response.Description;
            this.ExpiredAt = response.ExpiredAt;
            this.CreatedAt = response.CreatedAt;
            this.Status = response.Status;
            // TODO: resolve from BusinessService
            this.BusinessName = response.BusinessName;
            this.BusinessImageUrl = response.BusinessImageUrl;
            this.IsRedeemed = response.IsRedeemed;
        }

        public Coupon(string Id, string BusinessName, string BusinessImageUrl, string Description, DateTime CreatedAt, DateTime ExpiredAt, CouponStatus Status, bool IsRedeemed)
        {
            this.Id = Id;
            this.Description = Description;
            this.ExpiredAt = ExpiredAt;
            this.CreatedAt = CreatedAt;
            this.Status = Status;
            // TODO: resolve from BusinessService
            this.BusinessName = BusinessName;
            this.BusinessImageUrl = BusinessImageUrl;
            this.IsRedeemed = IsRedeemed;
        }
        public string Id { get; set; }

        public string BusinessName { get; set; }

        public string BusinessImageUrl { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpiredAt { get; set; }

        public CouponStatus Status { get; set; }

        public bool IsRedeemed { get; set; }
    }

    // TODO: move to seperate folder
    public class CouponResponse
    {
        public CouponResponse(string Id, string BusinessName, string BusinessImageUrl, string Description, DateTime CreatedAt, DateTime ExpiredAt, CouponStatus Status, bool IsRedeemed)
        {
            this.Id = Id;
            this.Description = Description;
            this.ExpiredAt = ExpiredAt;
            this.CreatedAt = CreatedAt;
            this.Status = Status;
            // TODO: resolve from BusinessService
            this.BusinessName = BusinessName;
            this.BusinessImageUrl = BusinessImageUrl;
            this.IsRedeemed = IsRedeemed;
        }
        public string Id { get; set; }

        public string BusinessName { get; set; }

        public string BusinessImageUrl { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpiredAt { get; set; }

        public CouponStatus Status { get; set; }

        public bool IsRedeemed { get; set; }
    }
}

