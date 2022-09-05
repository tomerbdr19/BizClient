using BizModels.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BizService.Services
{
    public class ChatService : ServiceBase
    {
        protected override string Path => "chat";

        async public Task<Chat> UpdateChat(Chat chat)
        {
            var retChat = await PostAsync<Chat>($"{Path}/status", new { business = chat.Business.Id ,  chat = chat.Id ,  status = chat.Status });
            return retChat;
        }

        public async Task<List<Chat>> GetAllChats(User user, string status)
        {
            var chats = await GetAsync<List<Chat>>($"{Path}/all", new Dictionary<string, string> { { "user", user.Id }, {"status", status } });
            return chats;
        }

        public async Task<List<Chat>> GetAllChats(Business business,string status)
        {
            var chats = await GetAsync<List<Chat>>($"{Path}/all", new Dictionary<string, string> { { "business", business.Id }, { "status", status } });
            return chats;
        }

        public async Task<Chat> GetChatByParticipants(User user, Business business)
        {
            var chats = await GetAsync<List<Chat>>($"{Path}", new Dictionary<string, string> { { "user", user.Id }, { "business", business.Id } });
            return chats[0];
        }

        async public Task<Message> PostChatMessages(string messageSender, string messageSenderType, string chatId,string messageContent)
        {
            var message = await PostAsync<Message>($"{Path}/messages", new { sender = messageSender, senderType = messageSenderType, chat = chatId, content = messageContent });
            return message;
        }

        async public Task<List<Message>> GetChatMessages(Chat chat)
        {
            var messages = await GetAsync<List<Message>>($"{Path}/messages", new Dictionary<string, string> { { "chat", chat.Id } });
            return messages;
        }
    }
}
