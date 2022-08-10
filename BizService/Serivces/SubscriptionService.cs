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

        public Task GetBusinessSubscriptions()
        {
            // TODO: implement
            return Task.CompletedTask;
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
