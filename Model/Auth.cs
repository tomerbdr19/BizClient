using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Model
{
    public class Auth
    {
        public Auth(AuthResponse response)
        {
            UserId = response.UserId;
            Email = response.Email;
            Password = response.Password;
        }

        public string UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool Match(string id, string email, string password)
        {
            bool isMatch = false;
            if (id == UserId && email == Email && password == Password)
                isMatch = true;
            return isMatch;
        }
    }

    public class AuthResponse
    {
        public AuthResponse(string id, string email, string password)
        {
            UserId = id;
            this.Email = email;
            Password = password;
        }

        public string UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
