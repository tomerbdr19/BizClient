using System;
//using static Android.Icu.Text.IDNA;

namespace BizClient.Model
{

    public struct BusinessLocation
    {
        public BusinessLocation(string country, string city, string street)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
        }

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public override string ToString()
        {
            return $"{Country}, {City}, {Street}";
        }
    }

    public struct BusinessContact
    {
        public BusinessContact(string phones, string email)
        {
            this.Phones = phones;
            this.Email = email;
        }
        public string Phones { get; set; }
        public string Email { get; set; }
    }
    public struct BusinessInfo
    {
        public BusinessInfo(string description, string country, string city, string street, string phones, string email) : this()
        {
            this.Description = description;
            this.Location = new BusinessLocation(country, city, street);
            this.Contact = new BusinessContact(phones, email);
        }

        public string Description { get; set; }
        public BusinessLocation Location { get; set; }
        public BusinessContact Contact { get; set; }


    }

    public class Business : ObservableObject
    {
        public Business(BusinessResponse response)
        {
            Id = response.Id;
            OwnerId = response.OwnerId;
            Info = new BusinessInfo(response.Info.Description, response.Info.Location.Country, response.Info.Location.City, response.Info.Location.Street, response.Info.Contact.Phones, response.Info.Contact.Email);
            ImageUrl = response.ImageUrl;
            Name = response.Name;
        }

        public Business(string id, string ownerId, string name, string description, string imageUrl, string country, string city, string street, string phones, string email)
        {
            Id = id;
            OwnerId = ownerId;
            Info = new BusinessInfo(description, country, city, street, phones, email);
            ImageUrl = imageUrl;
            Name = name;
        }
        public BusinessInfo Info { get; set; }

        public string Id { get; set; }
        public string OwnerId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }

        public bool PublishPost(string description)//TODO
        {
            bool isSuccess = true;
            return isSuccess;
        }

        public bool AddCoupon(string description)//TODO
        {
            bool isSuccess = true;
            return isSuccess;
        }
    }

    public class BusinessResponse
    {
        public BusinessResponse(string id, string ownerId, string name, string description, string imageUrl, string country, string city, string street, string phones, string email)
        {
            Id = id;
            OwnerId = ownerId;
            Info = new BusinessInfo(description, country, city, street, phones, email);
            ImageUrl = imageUrl;
            Name = name;
        }

        public BusinessResponse() { }

        public BusinessInfo Info { get; set; }

        public string Id { get; set; }
        public string OwnerId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
    }
}

