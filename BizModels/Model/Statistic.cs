using System;
using System.Collections.Generic;
using System.Linq;

namespace BizModels.Model
{
    public class Statistic
    {
        public List<ChartData> ActivityList { get; set; } = new();
        public int Average { get; set; }
        public int Total => ActivityList.Sum(_ => _.Value);
        public int Current => ActivityList.Count > 0 ? ActivityList[ActivityList.Count - 1].Value : 0;
        private float _percentageFromAverage => Average > 0 ? (((float)Current - Average) / Average * 100) : 0;
        public bool IsCurrentMoreThenAverage => _percentageFromAverage >= 0;
        public string PercentageFromAverage => _percentageFromAverage.ToString("0.00");
    }
}

