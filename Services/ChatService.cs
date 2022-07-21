using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class ChatService
    {
        public ChatService()
{
            httpClient = new HttpClient();
        }

        public async Task<ChatResponse> GetChatById(string id)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<ChatResponse> chats = new();
            ChatResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                chats = await response.Content.ReadFromJsonAsync<List<ChatResponse>>();
                foreach (ChatResponse chat in chats)
                {
                    if (chat.Id == id)
                    {
                        retVal = chat;
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
            //List<ChatResponse> chats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChatResponse>>(json);
            //ChatResponse retVal = null;
            //foreach (ChatResponse chat in chats)
            //{
            //    if (chat.Id == id)
            //    {
            //        retVal = chat;
            //        break;
            //    }
            //}
            //if (retVal == null)
            //{
            //    //TODO hendle error
            //}

            //return retVal;
        }

        public async Task<List<ChatResponse>> GetAllChatsByUserId(string userId)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<ChatResponse> chats = new();
            List<ChatResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                chats = await response.Content.ReadFromJsonAsync<List<ChatResponse>>();
                foreach (ChatResponse chat in chats)
                {
                    if (chat.UserId == userId)
                    {
                        retVal.Add(chat);
                    }
                }

            }
            if (retVal.Count == 0)
            {
                //TODO hendle error
            }
            return retVal;
        }

        public async Task<List<ChatResponse>> GetAllChatsByBusinessId(string businessId)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<ChatResponse> chats = new();
            List<ChatResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                chats = await response.Content.ReadFromJsonAsync<List<ChatResponse>>();
                foreach (ChatResponse chat in chats)
                {
                    if (chat.BusinessId == businessId)
                    {
                        retVal.Add(chat);
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
