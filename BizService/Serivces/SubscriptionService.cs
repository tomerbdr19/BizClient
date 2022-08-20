using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BizModels.Model;

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
            var subscriptionsList = await GetAsync<List<Subscription>>(Path, new Dictionary<string, string>() { { "business", businessId } });
            return subscriptionsList;
        }

        async public Task<List<Subscription>> GetFilteredSubscriptions(string businessId, List<IFilter> filters)
        {
            var subscriptionsList = await PostAsync<List<Subscription>>($"{Path}/filter", new { business = businessId, filters = FilterRequestGenerator.Generate(filters) });
            return subscriptionsList;
        }

        async public Task<List<Subscription>> GetUserSubscriptions(string userId)
        {
            var subscriptionsList = await GetAsync<List<Subscription>>(Path, new Dictionary<string, string>() { { "user", userId } });
            return subscriptionsList;
        }

        async public Task<Subscription> getSubscription(string userId, string businessId)
        {
            var subscriptions = await GetAsync<List<Subscription>>(Path, new Dictionary<string, string>() { { "user", userId }, { "business", businessId } });
            return subscriptions.Count == 1 ? subscriptions[0] : null;
        }

        async public Task<Subscription> Subscribe(Subscription newSubscription)
        {
            var subscription = await PostAsync<Subscription>(Path, newSubscription);
            return subscription;
        }

        async public Task Unsubscribe(Subscription subscription)
        {
            await PostAsync<Subscription>($"{Path}/delete", subscription);
        }
    }
}
