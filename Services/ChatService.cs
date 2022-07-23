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
        public ChatService(SessionService sessionService, BusinessService businessService)
        {
            httpClient = new HttpClient();
            this.sessionService = sessionService;
            this.businessService = businessService;

        }

        private readonly SessionService sessionService;
        private readonly BusinessService businessService;
        public List<Chat> Chats { get; set; }

        public Task<List<Chat>> GetAllChats()
        {
            var loggedId = sessionService.GetLoggedId();
            Chats = Mocks.chats.ToList().FindAll(_ => _.UserId == loggedId || _.BusinessId == loggedId).ToList();
            return Task.FromResult(Chats);
        }

        public async Task<Chat> GetChatByParticipateId(string participateId)
        {
            if (Chats == null)
            {
                await GetAllChats();
            }

            return Chats.Find(_ => { return _.UserId == participateId || _.BusinessId == participateId; });
        }

        public async Task<Chat> GetChatById(string chatId)
        {
            if (Chats == null)
            {
                await GetAllChats();
            }

            return Chats.Find(_ => _.Id == chatId);
        }

        async public Task<List<Message>> GetChatMessages(string chatId)
        {
            List<Message> messagesList = new();

            var messagesResponse = Mocks.messages.ToList().FindAll(_ => _.ChatId == chatId);
            var chat = Chats.Find(_ => _.Id == chatId);

            var isUserMode = sessionService.IsUserMode;
            var business = await businessService.GetBusinessById(chat.BusinessId);

            var businessName = isUserMode ? business.Name : "";
            var businessImageUrl = isUserMode ? business.ImageUrl : "";
            var userName = isUserMode ? sessionService.GetLoggedName() : "";
            var userImageUrl = isUserMode ? sessionService.GetLoggedImageUrl() : "";

            messagesResponse.ForEach(_ => messagesList.Add(new Message
            {
                ChatId = _.ChatId,
                SenderId = _.SenderId,
                SenderImageUrl = _.SenderId == business.Id ? business.ImageUrl : userImageUrl,
                SenderName = _.SenderId == business.Id ? business.Name : userName,
                CreatedAt = _.CreatedAt,
                MessageContent = _.Content,
                Id = _.Id,
                IsSelf = _.SenderId == sessionService.GetLoggedId(),
            }));

            return messagesList;
        }

        private HttpClient httpClient;
    }
}
