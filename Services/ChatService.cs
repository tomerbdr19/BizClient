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

            // the id of the logged user/business -> should be resolved by auth service
            string authId = "1";
            GetAllChats(authId);
        }

        public List<Chat> Chats { get; } = new List<Chat>();

        // find all chats by given id
        public Task GetAllChats(string userOrBusinessId)
        {
            // TODO : async call
            Chats.Add(new Chat(new ChatResponse("1", "2", "1", DateTime.Now)));
            
            return Task.CompletedTask;
        }

        public Chat GetChatByParticipateId(string participateId)
        {
            return Chats.Find(_ => { return _.UserId == participateId || _.BusinessId == participateId; });
        }

        async public Task<List<Message>> GetChatMessages(string chatId)
        {
            List<Message> messagesList = new();

            // async request
            var messagesResponse = new List<MessageResponse> { new MessageResponse("1", "1", "2", "user", DateTime.Now), new MessageResponse("1", "1", "2", "business", DateTime.Now) };

            // resolve from services
            Business business = Mocks.businesses[0];
            // implement mock
            var UserId = "1";
            var UserImageUrl = "";
            var UserName = "Tomer";

            messagesResponse.ForEach(_ => messagesList.Add(new Message {
                ChatId = _.ChatId,
                SenderId = _.SenderId,
                SenderImageUrl = _.SenderId == UserId ? UserImageUrl : business.ImageUrl,
                SenderName = _.SenderId == UserId ? UserName : business.Name,
                CreatedAt = _.CreatedAt,
                MessageContent = _.Content,
                Id = _.Id,
                IsSelf = _.SenderId == "2",
            }));

            return messagesList;
        }

        private HttpClient httpClient;
    }
}
