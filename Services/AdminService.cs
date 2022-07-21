using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Services
{
    public class AdminService
    {
        public AdminService()
        {
            httpClient = new HttpClient();
        }

        public async Task<AdminResponse> GetAdminById(string id)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<AdminResponse> admins = new();
            AdminResponse retVal = null;
            if (response.IsSuccessStatusCode)
            {
                admins = await response.Content.ReadFromJsonAsync<List<AdminResponse>>();
                foreach (AdminResponse admin in admins)
                {
                    if (admin.Id == id)
                    {
                        retVal = admin;
                        break;
                    }
                }

            }
            if (retVal == null)
            {
                //TODO hendle error
            }
            return retVal;

            //string json = System.IO.File.ReadAllText(@"TODO add path");
            //List<AdminResponse> admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<AdminResponse>>(json);
            //AdminResponse retVal = null;
            //foreach (AdminResponse admin in admins)
            //{
            //    if (admin.Id == id)
            //    {
            //        retVal = admin;
            //        break;
            //    }
            //}
            //if (retVal == null)
            //{
            //    //TODO hendle error
            //}

            //return retVal;
        }

        public async Task<List<AdminResponse>> GetAllAdminByBusinessId(string businessId)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<AdminResponse> admins = new();
            List<AdminResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                admins = await response.Content.ReadFromJsonAsync<List<AdminResponse>>();
                foreach (AdminResponse admin in admins)
                {
                    if (admin.BusinessId == businessId)
                    {
                        retVal.Add(admin);
                    }
                }

            }
            if (retVal.Count == 0)
            {
                //TODO hendle error
            }
            return retVal;
        }

        public async Task<List<AdminResponse>> GetAllOwners(string businessId)
        {
            var url = "TODO add path";//TODO
            var response = await httpClient.GetAsync(url);
            List<AdminResponse> admins = new();
            List<AdminResponse> retVal = new();
            if (response.IsSuccessStatusCode)
            {
                admins = await response.Content.ReadFromJsonAsync<List<AdminResponse>>();
                foreach (AdminResponse admin in admins)
                {
                    if (admin.IsOwner)
                    {
                        retVal.Add(admin);
                    }
                }

            }
            if (retVal.Count == 0)
            {
                //TODO hendle error
            }
            return retVal;
        }

        private HttpClient httpClient;
    }
}
