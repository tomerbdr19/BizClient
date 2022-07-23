using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class PostService
    {
        public PostService(SessionService sessionService)
        {
            httpClient = new HttpClient();
            this.sessionService = sessionService;
        }

        private HttpClient httpClient;
        private readonly SessionService sessionService;

        public Task<List<Post>> GetUserRecentPosts(int page = 0)
        {
            // TODO implement
            return Task.FromResult(Mocks.posts.ToList());
        }

        public Task<List<Post>> GetBusinessPosts(string businessId, int page = 0)
        {
            // TODO implement
            return Task.FromResult(Mocks.posts.ToList().FindAll(_ => _.BusinessId == businessId));
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
