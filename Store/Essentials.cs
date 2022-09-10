using System;
namespace BizClient
{
    public static class Store
    {
        public static ServicesStore ServicesStore = new();
        public static Auth Auth;

        public static string Token => Auth.Token;
        public static bool IsUser => Auth.User != null;
        public static bool IsBusiness => Auth.Business != null;
        public static string UserId => Auth.User?.Id;
        public static string BusinessId => Auth.Business?.Id;

        public static string NewDeviceToken { get; set; }
    }
}

