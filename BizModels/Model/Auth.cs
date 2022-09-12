using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizModels.Model
{
    public class Auth
    {
        public string Token { get; set; }
        public string DeviceToken { get; set; }
        public User User { get; set; }
        public Business Business { get; set; }
        public DateTime LoggedAt = new();
    }
}
