using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class UserService
    {
        public User GetPostById(string id)
        {
            string json = System.IO.File.ReadAllText(@"TODO add path");
            List<User> users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(json);
            User retVal = null;
            foreach (User user in users)
            {
                if (user._id == id)
                {
                    retVal = user;
                    break;
                }
            }
            if (retVal == null)
            {
                //TODO hendle error
            }

            return retVal;
        }
    }
}
