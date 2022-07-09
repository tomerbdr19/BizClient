using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace BizClient.Services
{
    public class BusinessService
    {
        public Business GetBusinessById(string id)
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\amitk\OneDrive\Desktop\Studies\Final project\BizClient\Mock\Business.json");
            List<Business> businesses = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Business>>(json);
            Business retVal = null;
            foreach (Business business in businesses)
            {
                if (business._id == id)
                {
                    retVal = business;
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
