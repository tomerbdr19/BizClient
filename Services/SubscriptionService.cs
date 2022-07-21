using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class SubscriptionService
    {
        public SubscriptionService()
{
            httpClient = new HttpClient();
        }

        public async Task<SubscriptionResponse> GetSubscriptionByUserIdAndBusinessId(string userId, string businessId)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<SubscriptionResponse> Subscriptions = new();
            SubscriptionResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                Subscriptions = await response.Content.ReadFromJsonAsync<List<SubscriptionResponse>>();
                foreach (SubscriptionResponse subscription in Subscriptions)
                {
                    if (subscription.UserId == userId && subscription.BusinessId == businessId)
                    {
                        retVal = subscription;
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
            //List<SubscriptionResponse> Subscriptions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SubscriptionResponse>>(json);
            //SubscriptionResponse retVal = null;
            //foreach (SubscriptionResponse Subscription in Subscriptions)
            //{
            //    if (Subscription.UserId == id)
            //    {
            //        retVal = Subscription;
            //        break;
            //    }
            //}
            //if (retVal == null)
            //{
            //    //TODO hendle error
            //}

            //return retVal;
        }

        public async Task<List<SubscriptionResponse>> GetAllSubscriptionByBusinessId(string businessId)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<SubscriptionResponse> Subscriptions = new();
            List<SubscriptionResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                Subscriptions = await response.Content.ReadFromJsonAsync<List<SubscriptionResponse>>();
                foreach (SubscriptionResponse subscription in Subscriptions)
                {
                    if (subscription.BusinessId == businessId)
                    {
                        retVal.Add(subscription);
                    }
                }

            }
            if (retVal == null)
            {
                //TODO hendle error
            }
            return retVal;
        }

        public async Task<List<SubscriptionResponse>> GetAllSubscriptionByUserId(string userId)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<SubscriptionResponse> Subscriptions = new();
            List<SubscriptionResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                Subscriptions = await response.Content.ReadFromJsonAsync<List<SubscriptionResponse>>();
                foreach (SubscriptionResponse subscription in Subscriptions)
                {
                    if (subscription.UserId == userId)
                    {
                        retVal.Add(subscription);
                    }
                }

            }
            if (retVal == null)
            {
                //TODO hendle error
            }
            return retVal;
        }

        private HttpClient httpClient;
    }
}
