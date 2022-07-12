using System;
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
    }
}

