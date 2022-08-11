using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizModels.Model
{
    public class Message
    {
        public string Id { get; set; }
        public string Chat { get; set; }
        public BaseUserBusiness Sender { get; set; }
        public string SenderType { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
