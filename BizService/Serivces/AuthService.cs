using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BizService.Services
{
    public class AuthService : ServiceBase
    {
        protected override string Path => "auth";

        async public Task<Auth> Login(string email, string password)
        {
            var auth = await PostAsync<Auth>($"{Path}/login", new { email, password });
            return auth;
        }

        async public Task<Auth> Login(string token)
        {
            var auth = await PostAsync<Auth>($"{Path}/login", new { token });
            return auth;
        }

        async public Task<Auth> Register(string email, string password)
        {
            var auth = await PostAsync<Auth>($"{Path}/register", new { email, password });
            return auth;
        }
    }
}

