using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class PostService
    {
        public Post GetPostById(string id)
        {
            string json = System.IO.File.ReadAllText(@"TODO add path");
            List<Post> posts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Post>>(json);
            Post retVal = null;
            foreach (Post post in posts)
            {
                if (post._id == id)
                {
                    retVal = post;
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
