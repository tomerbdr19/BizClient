using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizModels.Model
{
    public class Subscription
    {
        public string Id { get; set; }
        public User User { get; set; }
        public Business Business { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}