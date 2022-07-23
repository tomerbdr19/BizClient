using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Model
{
    public class Message : ObservableObject
    {
        public string Id { get; set; }

        public string ChatId { get; set; }

        public string SenderId { get; set; }

        public string MessageContent { get; set; }

        public DateTime CreatedAt { get; set; }

        public string SenderImageUrl { get; set; }

        public string SenderName { get; set; }

        public bool IsSelf { get; set; } = true;
    }

    public class MessageResponse
    {
        public MessageResponse(string id, string chatId, string senderId, string content, DateTime createdAt)
        {
            Id = id;
            ChatId = chatId;
            SenderId = senderId;
            Content = content;
            CreatedAt = createdAt;
        }

        public string Id { get; set; }

        public string ChatId { get; set; }

        public string SenderId { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
