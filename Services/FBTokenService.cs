using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class FBTokenService
    {
        public FBTokenService()
        {
            httpClient = new HttpClient();
        }

        public async Task<FBTokenResponse> GetFBTokenByToken(string token)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<FBTokenResponse> fBTokens = new();
            FBTokenResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                fBTokens = await response.Content.ReadFromJsonAsync<List<FBTokenResponse>>();
                foreach (FBTokenResponse fBToken in fBTokens)
                {
                    if (fBToken.Token == token)
                    {
                        retVal = fBToken;
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
            //List<FBTokenResponse> fBTokens = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FBTokenResponse>>(json);
            //FBTokenResponse retVal = null;
            //foreach (FBTokenResponse fBToken in fBTokens)
            //{
            //    if (fBToken.Token == token)
            //    {
            //        retVal = fBToken;
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
