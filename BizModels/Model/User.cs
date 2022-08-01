using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizModels.Model
{
    public class User
    {
        public User()
        {
            info = new UserInfo();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public UserInfo info { get; set; }
    }

    public struct UserInfo
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthDate { get; set; }
        public string region { get; set; }
        public string city { get; set; }
    }
}
