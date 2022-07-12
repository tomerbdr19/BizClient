namespace BizClient.ViewModel;

public partial class BusinessesPageViewModel : BaseViewModel
{

    public BusinessesPageViewModel()
    {
        Businesses.Add(new Business("1","123","Humus","Humus Resturant","https://st2.depositphotos.com/6331184/9676/i/450/depositphotos_96765686-stock-photo-homemade-hummus-with-pita-bread.jpg","Israel","Tel Aviv","Poriya 12","034466023","humus@gmail.com"));
        Businesses.Add(new Business("2","123","Burger King","Humus Resturant","https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Burger_King_logo_%281999%29.svg/1024px-Burger_King_logo_%281999%29.svg.png","Israel","Tel Aviv","Poriya 12","034466023","humus@gmail.com"));
        Businesses.Add(new Business("3","123","Pizza","Humus Resturant","https://img.freepik.com/free-photo/top-view-pepperoni-pizza-sliced-into-six-slices_141793-2157.jpg?t=st=1657119107~exp=1657119707~hmac=dca1292b53cbed4d75265301f6df90808b04fb8d60972fa1a1154f7275c04dbf&w=2000","Israel","Tel Aviv","Poriya 12","034466023","humus@gmail.com"));
    }

    public ObservableCollection<Business> Businesses { get; } = new();

    [ICommand]
    async Task GoToBusiness(Business business)
    {
        if (business == null)
            return;

        await Shell.Current.GoToAsync(Routes.Business, true, new Dictionary<string, object>
        {
            {"Business", business}
        });
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }
}