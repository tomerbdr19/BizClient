﻿using BizModels.Model;
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

        async public Task<Auth> Register(string email, string password, string type)
        {
            var auth = await PostAsync<Auth>($"{Path}/register", new { email, password, type });
            return auth;
        }

        public async Task<Auth> PostToken(User user, string token)
        {
            var auth = await PostAsync<Auth>($"{Path}/all", new { user.Id, token });
            return auth;
        }

        public async Task<Auth> PostToken(Business business, string token)
        {
            var auth = await PostAsync<Auth>($"{Path}/all", new { business.Id, token });
            return auth;
        }

    }
}

