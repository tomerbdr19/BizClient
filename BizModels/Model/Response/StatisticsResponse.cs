using System;
using System.Collections.Generic;

namespace BizModels.Model
{
    public class StatisticsResponse
    {
        public Statistic Subscriptions { get; set; } = new();
        public Statistic Views { get; set; } = new();
        public Statistic Coupons { get; set; } = new();
    };
}

