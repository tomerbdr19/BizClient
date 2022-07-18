using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Model
{
    public class Subscription
    {
        public Subscription(SubscriptionResponse response)
        {
            UserId = response.UserId;
            BusinessId = response.BusinessId;
            CreatedAt = response.CreatedAt;
        }

        public string UserId { get; set; }
        public string BusinessId { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class SubscriptionResponse
    {
        public SubscriptionResponse(string userId, string businessId, DateTime createdAt)
        {
            UserId = userId;
            BusinessId = businessId;
            CreatedAt = createdAt;
        }

        public string UserId { get; set; }
        public string BusinessId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
