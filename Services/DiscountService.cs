using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class DiscountService
    {
        public DiscountService()
        {
            httpClient = new HttpClient();
        }

        public async Task<DiscountResponse> GetDiscountById(string id)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<DiscountResponse> discounts = new();
            DiscountResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                discounts = await response.Content.ReadFromJsonAsync<List<DiscountResponse>>();
                foreach (DiscountResponse discount in discounts)
                {
                    if (discount.Id == id)
                    {
                        retVal = discount;
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
            //List<DiscountResponse> discounts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DiscountResponse>>(json);
            //DiscountResponse retVal = null;
            //foreach (DiscountResponse discount in discounts)
            //{
            //    if (discount.Id == id)
            //    {
            //        retVal = discount;
            //        break;
            //    }
            //}
            //if (retVal == null)
            //{
            //    //TODO hendle error
            //}

            //return retVal;
        }

        public async Task<List<DiscountResponse>> GetAllDiscountsByBusinessId(string businessId)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<DiscountResponse> discounts = new();
            List<DiscountResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                discounts = await response.Content.ReadFromJsonAsync<List<DiscountResponse>>();
                foreach (DiscountResponse discount in discounts)
                {
                    if (discount.BusinessId == businessId)
                    {
                        retVal.Add(discount);
                    }
                }

            }
            if (retVal.Count == 0)
            {
                //TODO hendle error
            }
            return retVal;
        }

        public async Task<List<DiscountResponse>> GetAllDiscountsByBusinessIdAndType(string businessId, string type)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<DiscountResponse> discounts = new();
            List<DiscountResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                discounts = await response.Content.ReadFromJsonAsync<List<DiscountResponse>>();
                foreach (DiscountResponse discount in discounts)
                {
                    if (discount.BusinessId == businessId && discount.Type == type)
                    {
                        retVal.Add(discount);
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
