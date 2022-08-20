using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizModels.Model
{
    public class Subscription
    {
        public string Id { get; set; }
        public User User { get; set; }
        public Business Business { get; set; }
        public DateTime CreatedAt { get; set; }
        public Activity Activity { get; set; }
    }

    public class Activity
    {
        public int TotalCoupons { get; set; }
        public int ActiveCoupons { get; set; }
        public int RedeemedCoupons { get; set; }
        public int RedeemPercentage => TotalCoupons == 0 ? 0 : (int)Math.Round((double)(100 * RedeemedCoupons) / TotalCoupons);
        public Nullable<DateTime> LastRedeemed { get; set; } = null;
    }
}