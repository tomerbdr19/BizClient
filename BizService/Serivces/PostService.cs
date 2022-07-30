using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BizService.Services
{
    public class PostService : ServiceBase
    {
        protected override string Path => "post";

        public Task<List<Post>> GetUserRecentPosts(int page = 0)
        {
            // TODO implement
            return Task.FromResult<List<Post>>(null);
        }

        public Task<List<Post>> GetBusinessPosts(string businessId, int page = 0)
        {
            // TODO implement
            return Task.FromResult<List<Post>>(null);
        }

        public Task LikePost(string postId)
        {
            // TODO implement
            return Task.CompletedTask;
        }

        public Task DeletePost(string postId)
        {
            // TODO implement
            return Task.CompletedTask;
        }

        public Task PublishPost(Post Post)
        {
            // TODO implement
            return Task.CompletedTask;
        }
    }
}
