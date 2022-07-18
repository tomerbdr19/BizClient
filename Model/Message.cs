using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Model
{
    public class Message
    {
        public Message(MessageResponse response)
        {
            MessageId = response.MessageId;
            FromBusinessId = response.FromBusinessId;
            FromUserId = response.FromUserId;
            Content = response.Content;
            CreatedAt = response.CreatedAt;
        }

        public string MessageId { get; set; }

        public string FromUserId { get; set; }

        public string FromBusinessId { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class MessageResponse
    {
        public MessageResponse(string messageId, string fromUserId, string fromBusinessId, string content, DateTime createdAt)
        {
            MessageId = messageId;
            FromUserId = fromUserId;
            FromBusinessId = fromBusinessId;
            Content = content;
            CreatedAt = createdAt;
        }

        public string MessageId { get; set; }

        public string FromUserId { get; set; }

        public string FromBusinessId { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
