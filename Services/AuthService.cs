using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class AuthService
    {
        public AuthService()
        {
            httpClient = new HttpClient();
        }

        public async Task<AuthResponse> GetAuthById(string id)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<AuthResponse> auths = new();
            AuthResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                auths = await response.Content.ReadFromJsonAsync<List<AuthResponse>>();
                foreach (AuthResponse auth in auths)
                {
                    if (auth.UserId == id)
                    {
                        retVal = auth;
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
            //List<AuthResponse> auths = Newtonsoft.Json.JsonConvert.DeserializeObject<List<AuthResponse>>(json);
            //AuthResponse retVal = null;
            //foreach (AuthResponse auth in auths)
            //{
            //    if (auth.UserId == id)
            //    {
            //        retVal = auth;
            //        break;
            //    }
            //}
            //if (retVal == null)
            //{
            //    //TODO hendle error
            //}

            //return retVal;
        }

        public async Task<AuthResponse> GetAuthByEmailAndPassword(string email, string password)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<AuthResponse> auths = new();
            AuthResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                auths = await response.Content.ReadFromJsonAsync<List<AuthResponse>>();
                foreach (AuthResponse auth in auths)
                {
                    if ((auth.Email == email) && (auth.Password == password))
                    {
                        retVal = auth;
                        break;
                    }
                    if(auth.Email == email)
                    {
                        //TODO hendle error
                    }
                }

            }
            if (retVal == null)
            {
                //TODO hendle error
            }
            return retVal;
        }

        private HttpClient httpClient;
    }
}
