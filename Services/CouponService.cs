using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class CouponService
    {
        public Coupon GetCouponById(string id)
        {
            string json = System.IO.File.ReadAllText(@"TODO add path");
            List<Coupon> coupons = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Coupon>>(json);
            Coupon retVal = null;
            foreach (Coupon coupon in coupons)
            {
                if (coupon._id == id)
                {
                    retVal = coupon;
                    break;
                }
            }
            if (retVal == null)
            {
                //TODO hendle error
            }

            return retVal;
        }
    }
}

