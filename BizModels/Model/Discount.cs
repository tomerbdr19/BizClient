using System;
namespace BizModels.Model
{
    public class Discount
    {
        public string Id { get; set; }
        public Business Business { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
        public bool IsPublic { get; set; }
        public int Limit { get; set; }

        public bool IsExpired => DateTime.Now > ExpiredAt;
        public int DaysToEnd => (ExpiredAt - DateTime.Now).Days;
        public DiscountStat Statistics { get; set; } = new();

    }

    public class DiscountStat
    {
        public int Redeemed { get; set; }
        public int Available { get; set; }
        public int Total { get; set; }
        public float Percentage { get; set; }
    }
}

