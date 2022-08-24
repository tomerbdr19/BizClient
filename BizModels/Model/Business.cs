using System;
using System.Collections.Generic;

namespace BizModels.Model
{
    public class Business : BaseUserBusiness
    {
        public string Id { get; set; }
        public new string Name { get; set; }
        public new string ImageUrl { get; set; }
        public BusinessInfo Info { get; set; } = new();
        public string OwnerId { get; set; }
    }

    public class BusinessInfo
    {
        public string Description { get; set; }
        public BusinessLocation Location { get; set; } = new();
        public BusinessContact Contact { get; set; } = new();
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
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

