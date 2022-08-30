using System;
using System.Collections.Generic;

namespace BizModels.Model
{
    public class Statistic
    {
        public List<ChartData> ActivityList { get; set; } = new();
        public int Average { get; set; }
    }
}

