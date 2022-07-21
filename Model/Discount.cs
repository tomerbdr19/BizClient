using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Model
{
    public class Discount
    {
        public Discount(DiscountResponse response)
        {
            Id = response.Id;
            BusinessId = response.BusinessId;
            this.CreatedAt = response.CreatedAt;
            this.Type = response.Type;
        }

        public string Id { get; set; }
        public string BusinessId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Type { get; set; }
    }

    public class DiscountResponse
    {
        public DiscountResponse(string id, string businessId, DateTime createdAt, string type)
        {
            Id = id;
            BusinessId = businessId;
            this.CreatedAt = createdAt;
            this.Type = type;
        }

        public string Id { get; set; }
        public string BusinessId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Type { get; set; }
    }
}
