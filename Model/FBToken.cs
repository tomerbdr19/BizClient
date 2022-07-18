using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Model
{
    public class FBToken
    {
        public FBToken(FBTokenResponse response)
        {
            BusinessId = response.BusinessId;
            Token = response.Token;
            CreatedAt = response.CreatedAt;
        }

        public string BusinessId { get; set; }
        public string Token { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class FBTokenResponse
    {
        public FBTokenResponse(string businessId, string token, DateTime createdAt)
        {
            BusinessId = businessId;
            Token = token;
            CreatedAt = createdAt;
        }

        public string BusinessId { get; set; }
        public string Token { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
