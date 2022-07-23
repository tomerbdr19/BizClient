using System;
namespace BizClient.Services
{
    public class SessionService
    {
        enum LogMode
        {
            User,
            Business,
            Null,
        };

        public SessionService()
        {
        }

        private LogMode mode;
        private User loggedUser;
        private Business loggedBusiness;
        private string token;


        public bool IsUserMode => mode == LogMode.User;
        public bool IsAuth => token != null;
        public string Token => token;

        async public void Login(string username, string password)
        {
            // TODO: implement

            token = "123";
            var userId = "1";
            mode = LogMode.User;
            loggedUser = new User(new UserResponse("1", "tomer", "binder", "today", "israel", "tel-aviv"));

            return;
        }

        public void Logout()
        {
            mode = LogMode.Null;
            loggedUser = null;
            loggedBusiness = null;
            token = null;
        }

        public string GetLoggedId()
        {
            if (mode == LogMode.Null)
                return null;

            return mode == LogMode.User ? loggedUser._id : loggedBusiness.Id;
        }

        public string GetLoggedName()
        {
            if (mode == LogMode.Null)
                return null;

            return mode == LogMode.User ? loggedUser.info.firstName : loggedBusiness.Name;
        }

        public string GetLoggedImageUrl()
        {
            if (mode == LogMode.Null)
                return null;

            return mode == LogMode.User ? loggedUser.info.lastName : loggedBusiness.ImageUrl;
        }
    }
}

