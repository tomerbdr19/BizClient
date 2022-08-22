using System;
namespace BizClient
{
    public static class Routes
    {
        public static readonly String Base = "Base";
        public static readonly String Login = "Login";
        public static readonly String Home = "Home";
        public static readonly String Businesses = "Businesses";
        public static readonly String Business = "Business";
        public static readonly String Coupons = "Coupons";
        public static readonly String Chat = "Chat";
        public static readonly String QRCode = "QRCode";
        public static readonly String UserRegister = "UserRegister";
        public static readonly String BusinessesRegistration = "Businesse registration";

        public static readonly String HomeTab = $"//{Base}/{Home}";
        public static readonly String BusinessesTab = $"//{Base}/{Businesses}";
        public static readonly String CouponsTab = $"//{Base}/{Coupons}";

        public static readonly String AdminBase = "AdminBase";
        public static readonly String AdminHome = "AdminHome";
        public static readonly String QRScanner = "QRScanner";
        public static readonly String AdminChat = "AdminChat";

        public static readonly String AdminHomeTab = $"//{AdminBase}/{AdminHome}";
        public static readonly String QRScannerTab = $"//{AdminBase}/{QRScanner}";
        public static readonly String AdminChatTab = $"//{AdminBase}/{AdminChat}";
    }
}

