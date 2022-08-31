using System;
using System.Collections.Generic;

namespace BizModels.Model
{
    public class DiscountsActivity
    {
        public DiscountActivity Max { get; set; }
        public DiscountActivity Min { get; set; }
        public List<ChartData> Data { get; set; }
    }

    public class ChatsActivity
    {
        public List<ChartData> Data { get; set; }
    }

    public class DiscountActivity
    {
        public Discount Discount { get; set; }
        public int Total { get; set; }
        public int Redeemed { get; set; }
        public int Available => Total - Redeemed;
        public float RedeemStatus => (float)Redeemed / Total * 100;
        public List<ChartData> Data => new() { new() { Label = "redeemed", Value = Redeemed }, new() { Label = "available", Value = Available } };
    }
}