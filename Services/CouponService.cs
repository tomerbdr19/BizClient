using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class CouponService
    {
        public CouponService()
        {
            httpClient = new HttpClient();
        }

        public async Task<CouponResponse> GetCouponById(string id)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<CouponResponse> coupons = new();
            CouponResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                coupons = await response.Content.ReadFromJsonAsync<List<CouponResponse>>();
                foreach (CouponResponse coupon in coupons)
                {
                    if (coupon.Id == id)
                    {
                        retVal = coupon;
                        break;
                    }
                }

            }
            if (retVal == null)
            {
                //TODO hendle error
            }
            return retVal;


            //string json = System.IO.File.ReadAllText(@"TODO add path");
            //List<CouponResponse> coupons = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CouponResponse>>(json);
            //CouponResponse retVal = null;
            //foreach (CouponResponse coupon in coupons)
            //{
            //    if (coupon.Id == id)
            //    {
            //        retVal = coupon;
            //        break;
            //    }
            //}
            //if (retVal == null)
            //{
            //    //TODO hendle error
            //}

            //return retVal;
        }

        public async Task<List<CouponResponse>> GetAllCouponsByBusinessName(string businessName)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<CouponResponse> coupons = new();
            List<CouponResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                coupons = await response.Content.ReadFromJsonAsync<List<CouponResponse>>();
                foreach (CouponResponse coupon in coupons)
                {
                    if (coupon.BusinessName == businessName)
                    {
                        retVal.Add(coupon);
                    }
                }

            }
            if (retVal.Count == 0)
            {
                //TODO hendle error
            }
            return retVal;
        }

        public async Task<List<CouponResponse>> GetAllExpiredCouponsByBusinessName(string businessName)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<CouponResponse> coupons = new();
            List<CouponResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                coupons = await response.Content.ReadFromJsonAsync<List<CouponResponse>>();
                foreach (CouponResponse coupon in coupons)
                {
                    if (coupon.BusinessName == businessName && coupon.Status == CouponStatus.expired)
                    {
                        retVal.Add(coupon);
                    }
                }

            }
            if (retVal.Count == 0)
            {
                //TODO hendle error
            }
            return retVal;
        }

        public async Task<List<CouponResponse>> GetAllRedeemedCouponsByBusinessName(string businessName)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<CouponResponse> coupons = new();
            List<CouponResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                coupons = await response.Content.ReadFromJsonAsync<List<CouponResponse>>();
                foreach (CouponResponse coupon in coupons)
                {
                    if (coupon.BusinessName == businessName && coupon.Status == CouponStatus.redeemed)
                    {
                        retVal.Add(coupon);
                    }
                }

            }
            if (retVal.Count == 0)
            {
                //TODO hendle error
            }
            return retVal;
        }

        public async Task<List<CouponResponse>> GetAllAvailableCouponsByBusinessName(string businessName)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<CouponResponse> coupons = new();
            List<CouponResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                coupons = await response.Content.ReadFromJsonAsync<List<CouponResponse>>();
                foreach (CouponResponse coupon in coupons)
                {
                    if (coupon.BusinessName == businessName && coupon.Status == CouponStatus.available)
                    {
                        retVal.Add(coupon);
                    }
                }

            }
            if (retVal.Count == 0)
            {
                //TODO hendle error
            }
            return retVal;
        }

        private HttpClient httpClient;
    }
}

