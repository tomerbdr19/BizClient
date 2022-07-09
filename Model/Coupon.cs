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
        public Coupon()
        {
            _id = "123";
            Description = "100 NIS";
            expiredAt = new DateTime();
            // TODO: resolve from BusinessService
            //BusinessName = "McDonalds";
            BusinessImageUrl = "https://st2.depositphotos.com/6331184/9676/i/450/depositphotos_96765686-stock-photo-homemade-hummus-with-pita-bread.jpg";
            isClaimed = false;
        }

        public string _id { get; set; }
        public string businessId { get; set; }
        public string userId { get; set; }
        public string discountId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime expiredAt { get; set; }
        public CouponStatus status { get; set; }
        public Boolean isClaimed { get; set; }

        public string Description { get; set; }
        public string BusinessImageUrl { get; set; }


        //    public string Id { get; set; }

        //    public string BusinessName { get; set; }

        //    public string BusinessImageUrl { get; set; }

        //    public string Description { get; set; }

        //    public DateTime ExpiredAt { get; set; }

        //    public bool IsRedeemed { get; set; }
        //}

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
}

