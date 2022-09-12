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

        async public Task<Business> UpdateBusiness(Business newBusiness)
        {
            var business = await PostAsync<Business>(Path, new { business = newBusiness });
            return business;
        }

        async public Task<Business> UpdateBusinessTheme(string businessId, string key)
        {
            var business = await PostAsync<Business>($"{Path}/theme", new { business = businessId, key });
            return business;
        }

        async public Task<Business> AddBusinessImage(string businessId, string imageUrl)
        {
            var business = await PostAsync<Business>($"{Path}/add-image", new { business = businessId, imageUrl });
            return business;
        }

        async public Task<Business> DeleteBusinessImage(string businessId, string imageUrl)
        {
            var business = await PostAsync<Business>($"{Path}/delete-image", new { business = businessId, imageUrl });
            return business;
        }
        async public Task<StatisticsResponse> GetStatics(string businessId, string period, DateTime fromDate)
        {
            var statistics = await GetAsync<StatisticsResponse>($"{Path}/statistics", new Dictionary<string, string> { { "business", businessId }, { "period", period }, { "fromDate", JsonConvert.SerializeObject(fromDate) } });
            return statistics;
        }
        async public Task<ActivityResponse> GetActivity(string businessId)
        {
            var activity = await GetAsync<ActivityResponse>($"{Path}/activity", new Dictionary<string, string> { { "business", businessId } });
            return activity;
        }

        async public Task<List<Product>> GetAllProducts(string businessId)
        {
            var products = await GetAsync<List<Product>>($"{Path}/products", new Dictionary<string, string> { { "business", businessId } });
            return products;
        }

        async public Task<Product> AddProduct(string businessId, string name, string imageUrl,string price)
        {
            var product = await PostAsync<Product>($"{Path}/product", new { business = businessId, name, imageUrl, price });
            return product;
        }

        async public Task<Product> DeleteProduct(string businessId, string productId)
        {
            var retProduct = await PostAsync<Product>($"{Path}/delete-product", new { business = businessId, product = productId });
            return retProduct;
        }

        async public Task<Product> UpdateProductPrice(string businessId, string productId, string price)
        {
            var retProduct = await PostAsync<Product>($"{Path}/product-price", new { business = businessId, product = productId, price });
            return retProduct;
        }
    }
}
