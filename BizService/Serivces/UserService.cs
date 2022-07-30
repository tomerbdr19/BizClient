using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizService.Services
{
    public class UserService : ServiceBase
    {
        protected override string Path => "user";

        async public Task<User> GetUserById(string userId)
        {
            var user = await GetAsync<User>(Path, new Dictionary<string, string> { { "user", userId } });
            return user;
        }
    }
}
