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
        public BusinessTheme Theme { get; set; } = new();
    }

    public class BusinessInfo
    {
        public string Description { get; set; }
        public BusinessLocation Location { get; set; } = new();
        public BusinessContact Contact { get; set; } = new();
    }

    public class BusinessTheme
    {
        public string Key { get; set; }
    }

    public class BusinessLocation
    {
        public string City { get; set; }
        public string Street { get; set; }
        public override string ToString()
        {
            return $"{City}, {Street}";
        }
    }

    public class BusinessContact
    {
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

