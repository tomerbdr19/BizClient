using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class UserService
    {
        public UserService()
        {
            httpClient = new HttpClient();
        }

        public async Task<UserResponse> GetUserById(string id)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<UserResponse> users = new();
            UserResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadFromJsonAsync<List<UserResponse>>();
                foreach (UserResponse user in users)
                {
                    if (user._id == id)
                    {
                        retVal = user;
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
            //List<UserResponse> users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UserResponse>>(json);
            //UserResponse retVal = null;
            //foreach (UserResponse user in users)
            //{
            //    if (user._id == id)
            //    {
            //        retVal = user;
            //        break;
            //    }
            //}
            //if (retVal == null)
            //{
            //    //TODO hendle error
            //}

            //return retVal;
        }

        public async Task<List<UserResponse>> GetAllUserByCity(string city)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<UserResponse> users = new();
            List<UserResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadFromJsonAsync<List<UserResponse>>();
                foreach (UserResponse user in users)
                {
                    if (user.info.city == city)
                    {
                        retVal.Add(user);
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
