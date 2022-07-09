using System;
namespace BizClient.Model
{
    public struct Location
    {
        public Location(string country, string city, string street)
        {
            this.country = country;
            this.city = city;
            this.street = street;
        }

        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
    }

    public struct Contact
    {
        public Contact(string phones, string email)
        {
            this.phones = phones;
            this.email = email;
        }
        public string phones { get; set; }
        public string email { get; set; }
    }
    public struct BusinessInfo
    {
        public BusinessInfo(string name, string country, string city, string street, string phones, string email) : this()
        {
            this.name = name;
            this.location = new Location(country, city, street);
            this.contact = new Contact(phones, email);
        }

        public string name { get; set; }
        public Location location { get; set; }
        public Contact contact { get; set; }


    }

    public class Business
    {
        public Business(string id, string ownerId, string name, string imageUrl, string country, string city, string street, string phones, string email)
        {
            _id = id;
            OwnerId = ownerId;
            info = new BusinessInfo(name, country, city, street, phones, email);
            ImageUrl = imageUrl;
        }
        public BusinessInfo info { get; set; }

        public string _id { get; set; }
        public string OwnerId { get; set; }
        public string ImageUrl { get; set; }
    }

 //   public class Business
	//{

	//	//public Business(string name, string imageUrl)
	//	//{
	//	//	Name = name;
	//	//	ImageUrl = imageUrl;
	//	//}

	//	//public String Name { get; set;}
	//	//public String ImageUrl { get; set;}
	//}
}

