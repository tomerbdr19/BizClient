using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizModels.Model
{
    public class Chat
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string BusinessId { get; set; }
        public List<Message> messages { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
