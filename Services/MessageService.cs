using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class MessageService
    {
        public MessageService()
{
            httpClient = new HttpClient();
        }

        public async Task<MessageResponse> GetMessageById(string MessageId)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<MessageResponse> Messages = new();
            MessageResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                Messages = await response.Content.ReadFromJsonAsync<List<MessageResponse>>();
                foreach (MessageResponse Message in Messages)
                {
                    if (Message.MessageId == MessageId)
                    {
                        retVal = Message;
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
            //List<MessageResponse> Messages = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MessageResponse>>(json);
            //MessageResponse retVal = null;
            //foreach (MessageResponse Message in Messages)
            //{
            //    if (Message.MessageId == MessageId)
            //    {
            //        retVal = Message;
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
