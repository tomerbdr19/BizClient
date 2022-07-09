using System;
namespace BizClient.Model
{
    public class Coupon
    {
        public Coupon()
        {
            Id = "123";
            Description = "100 NIS";
            ExpiredAt = new DateTime();
            // TODO: resolve from BusinessService
            BusinessName = "McDonalds";
            BusinessImageUrl = "https://st2.depositphotos.com/6331184/9676/i/450/depositphotos_96765686-stock-photo-homemade-hummus-with-pita-bread.jpg";
            IsRedeemed = false;
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

