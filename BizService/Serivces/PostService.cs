using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BizModels.Model;

namespace BizService.Services
{
    public class PostService : ServiceBase
    {
        protected override string Path => "post";

        async public Task<List<Post>> GetUserRecentPosts(string userId, int page = 0)
        {
            var posts = await GetAsync<List<Post>>($"{Path}/recent", new Dictionary<string, string> { { "user", userId } });
            return posts;
        }

        async public Task<List<Post>> GetBusinessPosts(string businessId, int page = 0)
        {
            var posts = await GetAsync<List<Post>>(Path, new Dictionary<string, string> { { "business", businessId } });
            return posts;
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

        async public Task<Post> PublishPost(Post Post)
        {
            var post = await PostAsync<Post>(Path,new {Post.Business,Post.Caption,Post.ImageUrl});
            return post;
        }
    }
}
