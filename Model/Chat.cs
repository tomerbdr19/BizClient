using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Model
{
    public class Chat
    {
        public Chat(ChatResponse respons)
        {
            Id = respons.Id;
            UserId = respons.UserId;
            BusinessId = respons.BusinessId;
            CreatedAt = respons.CreatedAt;
        }

        public string Id { get; set; }
        public string UserId { get; set; }
        public string BusinessId { get; set; }
        public DateTime CreatedAt { get; set; }   
    }

    public class ChatResponse
    {
        public ChatResponse(string id, string userId, string businessId, DateTime createdAt)
        {
            Id = id;
            UserId = userId;
            BusinessId = businessId;
            CreatedAt = createdAt;
        }

        public string Id { get; set; }
        public string UserId { get; set; }
        public string BusinessId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
