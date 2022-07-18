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
        public PostService()
        {
            httpClient = new HttpClient();
        }

        public async Task<PostResponse> GetPostById(string id)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<PostResponse> posts = new();
            PostResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                posts = await response.Content.ReadFromJsonAsync<List<PostResponse>>();
                foreach (PostResponse post in posts)
                {
                    if (post.Id == id)
                    {
                        retVal = post;
                        break;
                    }
                }

            }
            if (retVal == null)
            {
                //TODO hendle error
            }
            return retVal;

            //string json = System.IO.File.ReadAllText(@"TODO add path");
            //List<PostResponse> posts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PostResponse>>(json);
            //PostResponse retVal = null;
            //foreach (PostResponse post in posts)
            //{
            //    if (post.Id == id)
            //    {
            //        retVal = post;
            //        break;
            //    }
            //}
            //if (retVal == null)
            //{
            //    //TODO hendle error
            //}

            //return retVal;
        }

        private HttpClient httpClient;
    }
}
