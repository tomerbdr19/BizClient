//using LiveChartsCore;
//using LiveChartsCore.SkiaSharpView;

//namespace BizClient.ViewModel;


//public partial class CouponCartesianChartViewModel : BaseViewModel
//{
//    CouponCartesianChartViewModel(double expiredValue, double redeemedValue, double availableValue, string couponName)
//    {
//        this.Series = new ISeries[]
//        {
//            new LineSeries<string>
//            {
//                Values = new string[] { "Expired" , "Redeemed", "Available" }
//            },
//            new ColumnSeries<double>
//            {
//                Values = new double[] { expiredValue , redeemedValue, availableValue }
//            }
//        };
//        Title = couponName;
//        PieChart.Add(this.Series);
//    }
    
//    public string Title { get; set; }
//    public ISeries[] Series { get; set; }

//    public ObservableCollection<ISeries[]> PieChart { get; } = new();
//    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
//    {
//        base.OnPropertyChanged(e);
//    }
//}

