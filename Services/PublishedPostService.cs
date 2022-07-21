using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class PublishedPostService
    {
        public PublishedPostService()
        {
            httpClient = new HttpClient();
        }

        public async Task<PublishedPostResponse> GetPublishedPostById(string id)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<PublishedPostResponse> publishedPosts = new();
            PublishedPostResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                publishedPosts = await response.Content.ReadFromJsonAsync<List<PublishedPostResponse>>();
                foreach (PublishedPostResponse publishedPost in publishedPosts)
                {
                    if (publishedPost.Id == id)
                    {
                        retVal = publishedPost;
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
            //List<PublishedPostResponse> publishedPosts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PublishedPostResponse>>(json);
            //PublishedPostResponse retVal = null;
            //foreach (PublishedPostResponse publishedPost in publishedPosts)
            //{
            //    if (publishedPost.Id == id)
            //    {
            //        retVal = publishedPost;
            //        break;
            //    }
            //}
            //if (retVal == null)
            //{
            //    //TODO hendle error
            //}

            //return retVal;
        }

        public async Task<List<PublishedPostResponse>> GetAllPublishedPostByBusinessId(string businessId)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<PublishedPostResponse> publishedPosts = new();
            List<PublishedPostResponse> retVal = null;
            if (response.IsSuccessStatusCode)
            {
                publishedPosts = await response.Content.ReadFromJsonAsync<List<PublishedPostResponse>>();
                foreach (PublishedPostResponse publishedPost in publishedPosts)
                {
                    if (publishedPost.BusinessId == businessId)
                    {
                        retVal.Add(publishedPost);
                    }
                }

            }
            if (retVal.Count == 0)
            {
                //TODO hendle error
            }
            return retVal;
        }

        private HttpClient httpClient;
    }
}
