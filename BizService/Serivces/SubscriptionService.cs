using BizModels.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BizService.Services
{
    public class SubscriptionService : ServiceBase
    {
        public SubscriptionService()
        {
        }
        protected override string Path => "subscribe";

        async public Task<List<Subscription>> GetBusinessSubscriptions(string businessId)
        {
            var subscriptionsList = await GetAsync<List<Subscription>>(Path, new Dictionary<string, string>() { { "businessId", businessId } });
            return subscriptionsList;
        }

        async public Task<List<Subscription>> GetUserSubscriptions(string userId)
        {
            var subscriptionsList = await GetAsync<List<Subscription>>(Path, new Dictionary<string, string>() { { "user", userId } });
            return subscriptionsList;
        }

        public Task Subscribe(string businessId)
        {
            // TODO: implement
            return Task.CompletedTask;
        }

        public Task Unsubscribe(string businessId)
        {
            // TODO: implement
            return Task.CompletedTask;
        }
    }
}
