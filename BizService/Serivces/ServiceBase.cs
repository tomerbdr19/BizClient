using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Serialization;

namespace BizService.Services
{
    public abstract class ServiceBase
    {
        public ServiceBase()
        {
            _httpClient.BaseAddress = new Uri(this._baseUrl);
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
        }

        // TODO: get from consumer
        //private readonly string _baseUrl = "http://10.0.2.2:3000/api/";
        private readonly string _baseUrl = "http://localhost:3000/api/";
        protected abstract string Path { get; }

        private HttpClient _httpClient = new();

        private Uri BuildUrlWithQueryParams(string path, Dictionary<string, string> queryDictionary)
        {
            var uriBuilder = new UriBuilder(this._baseUrl);
            uriBuilder.Path = $"api/{path}";
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            queryDictionary?.Keys.ToList().ForEach(key => query[key] = queryDictionary[key]);
            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }

        private async Task<T> Deserialize<T>(HttpContent content)
        {
            var contentString = await content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(contentString);
        }

        private StringContent Serialize<T>(T instance)
        {
            var contentString = JsonConvert.SerializeObject(instance);
            return new StringContent(contentString, Encoding.UTF8, "application/json");
        }

        protected async Task<T> GetAsync<T>(string path, Dictionary<string, string> queryParams = null)
        {
            var url = BuildUrlWithQueryParams(path, queryParams);
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("get error");
            }

            var deserilaizedContent = await Deserialize<T>(response.Content);
            return deserilaizedContent;
        }

        protected async Task<T> PostAsync<T>(string path, object content)
        {
            var serializedContent = Serialize(content);
            var response = await _httpClient.PostAsync(path, serializedContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("post error");
            }

            var deserilaizedContent = await Deserialize<T>(response.Content);
            return deserilaizedContent;
        }

        protected async Task<T> PostFileAsync<T>(string path, byte[] content, string fileName)
        {
            ByteArrayContent bytes = new ByteArrayContent(content);
            bytes.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
            MultipartFormDataContent form = new MultipartFormDataContent();
            form.Headers.ContentType.MediaType = "multipart/form-data";
            form.Add(bytes, "file", fileName);

            var response = await _httpClient.PostAsync(path, form);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("post error");
            }

            var deserilaizedContent = await Deserialize<T>(response.Content);
            return deserilaizedContent;
        }
    }
}

