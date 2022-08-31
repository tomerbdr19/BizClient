namespace BizClient.ViewModel.BusinessViewModel;

public partial class BusinessHomePageViewModel : BaseViewModel
{

    public BusinessHomePageViewModel()
    {
    }

    async public void OnAppearing()
    {
        await FetchStatistics();
        await FetchActivity();
    }

    async private Task FetchStatistics()
    {
        IsLoading = true;

        var statistics = await this.businessService.GetStatics(Store.BusinessId, this.SelectedPeriod.PeriodString, this.GetFromDate());

        SubscriptionsStat = statistics.Subscriptions;
        CouponsStat = statistics.Coupons;
        ViewsStat = statistics.Views;

        IsLoading = false;
    }

    async private Task FetchActivity()
    {
        IsLoading = true;

        try
        {
            var statistics = await this.businessService.GetActivity(Store.BusinessId);
            DiscountsActivity = statistics.Discounts;
            ChatsActivity = statistics.Chats;
        }
        catch (Exception err)
        {
            Console.WriteLine(err);
        }

        IsLoading = false;
    }

    private readonly SubscriptionService subscriptionService = Store.ServicesStore.SubscriptionService;
    private readonly BusinessService businessService = Store.ServicesStore.BusinessService;
    private readonly CouponService couponService = Store.ServicesStore.CouponService;

    public List<PeriodOptions> Options { get; } = Period.GetPeriods;

    [ObservableProperty]
    public List<int> fromOptions = Period.GetPeriods[0].Options;

    [ObservableProperty]
    public int selectedFrom = Period.GetPeriods[0].Options[0];

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FromOptions))]
    [AlsoNotifyChangeFor(nameof(SelectedFrom))]
    public PeriodOptions selectedPeriod = Period.GetPeriods[0];

    [ICommand]
    public async void ApplyPeriodClick()
    {
        await FetchStatistics();
    }

    [ObservableProperty]
    public Statistic subscriptionsStat = new();

    [ObservableProperty]
    public Statistic couponsStat = new();

    [ObservableProperty]
    public Statistic viewsStat = new();

    [ObservableProperty]
    public DiscountsActivity discountsActivity = new();

    [ObservableProperty]
    public ChatsActivity chatsActivity = new();

    private DateTime GetFromDate()
    {
        if (SelectedPeriod.PeriodOptionsString == "week")
        {
            return DateTime.Now.AddDays(-7 * SelectedFrom);
        }
        else
        {
            return DateTime.Now.AddMonths(-1 * SelectedFrom);
        }
    }

    public Statistic Pie { get; } = new() { ActivityList = new() { new() { Value = 100, Label = "A" }, new() { Value = 150, Label = "A" } } };

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        switch (e.PropertyName)
        {
            case (nameof(SelectedPeriod)):
                FromOptions = SelectedPeriod.Options;
                SelectedFrom = SelectedPeriod.Options[0];
                break;
        }
    }

    public class CurrentActivity
    {
        public int Subscribers { get; set; }
        public int Redeems { get; set; }
        public int Posts { get; set; }
        public int Discounts { get; set; }
        public int Views { get; set; }
    }

    public class ChatActivity
    {
        public int New { get; set; }
        public int InProgress { get; set; }
    }

    public static class Period
    {
        private static PeriodOptions Day = new PeriodOptions { Options = new List<int> { 1, 2, 3, 4 }, PeriodString = "day", PeriodOptionsString = "week" };
        private static PeriodOptions Week = new PeriodOptions { Options = new List<int> { 1, 2, 3 }, PeriodString = "week", PeriodOptionsString = "month" };
        private static PeriodOptions Month = new PeriodOptions { Options = new List<int> { 3, 4, 5, 6 }, PeriodString = "month", PeriodOptionsString = "month" };

        public static List<PeriodOptions> GetPeriods = new() { Day, Week, Month };
    }

    public struct PeriodOptions
    {
        public List<int> Options { get; set; }
        public String PeriodOptionsString { get; set; }
        public String PeriodString { get; set; }

        public override string ToString()
        {
            return this.PeriodString;
        }
    }
}