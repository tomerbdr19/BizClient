using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Model
{
    public class Admin
    {
        public Admin(AdminResponse response)
        {
            Id = response.Id;
            BusinessId = response.BusinessId;
            IsOwner = response.IsOwner;
        }

        public string Id { get; set; }
        public string BusinessId { get; set; }
        public bool IsOwner { get; set; }
    }

    public class AdminResponse
    {
        public AdminResponse(string id, string businessId, bool isOwner)
        {
            Id = id;
            BusinessId = businessId;
            IsOwner = isOwner;
        }
    
        public string Id { get; set; }
        public string BusinessId { get; set; }
        public bool IsOwner { get; set; }
    }
}
