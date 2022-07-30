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

        public async Task<List<Chat>> GetAllChats(string participateId)
        {
            var chats = await GetAsync<List<Chat>>($"{Path}/all", new Dictionary<string, string> { { "participateId", participateId } });
            return chats;
        }

        public async Task<Chat> GetChatByParticipantsIds(string userId, string businessId)
        {
            var chat = await GetAsync<Chat>($"{Path}", new Dictionary<string, string> { { "user", userId }, { "business", businessId } });
            return chat;
        }

        async public Task<List<Message>> GetChatMessages(string chatId)
        {
            var messages = await GetAsync<List<Message>>($"{Path}/messages", new Dictionary<string, string> { { "chat", chatId } });
            return messages;
        }
    }
}
