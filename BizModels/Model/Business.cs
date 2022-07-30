using System;
using System.Collections.Generic;

namespace BizModels.Model
{
    public class Business
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public BusinessInfo Info { get; set; }
        public string OwnerId { get; set; }
    }

    public class BusinessInfo
    {
        public string Description { get; set; }
        public BusinessLocation Location { get; set; }
        public BusinessContact Contact { get; set; }
    }

    public class BusinessLocation
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public override string ToString()
        {
            return $"{Country}, {City}, {Street}";
        }
    }

    public class BusinessContact
    {
        public List<string> Phones { get; set; } = new();
        public List<string> Email { get; set; } = new();
    }
}

