using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace BizService.Services
{
    public class BusinessService : ServiceBase
    {
        public BusinessService()
        {
        }

        protected override string Path => "business";

        async public Task<List<Business>> GetBusinessesByIds(string[] businessesIds)
        {
            var businessesList = await PostAsync<List<Business>>($"{Path}/businesses", new { businessesIds });
            return businessesList;
        }

        public async Task<Business> GetBusinessById(string businessId)
        {
            var business = await GetAsync<Business>(Path, new Dictionary<string, string> { { "businessId", businessId } });
            return business;
        }

        async public Task<List<Business>> SearchBusinesses(string name)
        {
            var businessesList = await GetAsync<List<Business>>($"{Path}/search", new Dictionary<string, string> { { "name", name } });
            return businessesList;
        }
    }
}
