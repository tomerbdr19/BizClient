using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Model
{
    public class PublishedPost
    {
        public PublishedPost(PublishedPostResponse response)
        {
            Id = response.Id;
            BusinessId = response.BusinessId;
            Content = response.Content;
            Src = response.Src;
            CreatedAt = response.CreatedAt;
        }

        public string Id { get; set; }
        public string BusinessId { get; set; }
        public string Content { get; set; }
        public string Src { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class PublishedPostResponse
    {
        public PublishedPostResponse(string id, string businessId, string content, string src, DateTime createdAt)
        {
            Id = id;
            BusinessId = businessId;
            Content = content;
            Src = src;
            CreatedAt = createdAt;
        }

        public string Id { get; set; }
        public string BusinessId { get; set; }
        public string Content { get; set; }
        public string Src { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
