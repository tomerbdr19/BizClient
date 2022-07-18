using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json;
using System.Net.Http;


namespace BizClient.Services
{
    public class BusinessService
    {
        public BusinessService()
        {
            httpClient = new HttpClient();
        }

        public async Task<BusinessResponse> GetBusinessById(string id)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<BusinessResponse> businesses = new();
            BusinessResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                businesses = await response.Content.ReadFromJsonAsync<List<BusinessResponse>>();
                foreach (BusinessResponse business in businesses)
                {
                    if (business.Id == id)
                    {
                        retVal = business;
                        break;
                    }
                }
            }
            if (retVal == null)
            {
                //TODO hendle error
            }
            return retVal;

            //string json = System.IO.File.ReadAllText(@"C:\Users\amitk\OneDrive\Desktop\Studies\Final project\BizClient\Mock\Business.json");
            //List<BusinessResponse> businesses = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BusinessResponse>>(json);
            //BusinessResponse retVal = null;
            //foreach (BusinessResponse business in businesses)
            //{
            //    if (business.Id == id)
            //    {
            //        retVal = business;
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
