﻿using System;
namespace BizClient
{
    public static class Store
    {
        public static ServicesStore ServicesStore = new();
        public static Auth Auth;

        public static string Token => Auth.Token;
        public static string UserId => Auth.User.Id;
    }
}
