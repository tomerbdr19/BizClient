using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizClient.Model
{
    public struct UserInfo
    {
        public UserInfo(string firstName, string lastName, string birthDate, string region, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.region = region;
            this.city = city;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthDate { get; set; }
        public string region { get; set; }
        public string city { get; set; }
    }
    public class User
    {
        public User(UserResponse respons)
        {
            _id = respons._id;
            info = new UserInfo(respons.info.firstName, respons.info.lastName, respons.info.birthDate, respons.info.region, respons.info.city);
        }
        public User(string id, string firstName, string lastName, string birthDate, string region, string city)
        {
            _id = id;
            info = new UserInfo(firstName, lastName, birthDate, region, city);
        }
        public string _id { get; set; }
        public UserInfo info { get; set; }
    }

    public class UserResponse
    {
        public UserResponse(string id, string firstName, string lastName, string birthDate, string region, string city)
        {
            _id = id;
            info = new UserInfo(firstName, lastName, birthDate, region, city);
        }
        public string _id { get; set; }
        public UserInfo info { get; set; }
    }
}
