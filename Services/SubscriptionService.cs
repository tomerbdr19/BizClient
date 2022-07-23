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
        public SubscriptionService(SessionService sessionService)
        {
            httpClient = new HttpClient();
            this.sessionService = sessionService;
        }

        private HttpClient httpClient;
        private readonly SessionService sessionService;


        public Task GetBusinessSubscriptions()
        {
            // TODO: implement
            var businessId = sessionService.GetLoggedId();
            return Task.CompletedTask;
        }

        public Task<List<Subscription>> GetUserSubscriptions()
        {
            // TODO: implement
            return Task.FromResult(Mocks.subscriptions.ToList());
        }

        public Task Subscribe(string businessId)
        {
            // TODO: implement
            var userId = sessionService.GetLoggedId();
            return Task.CompletedTask;
        }

        public Task Unsubscribe(string businessId)
        {
            // TODO: implement
            var userId = sessionService.GetLoggedId();
            return Task.CompletedTask;
        }
    }
}
