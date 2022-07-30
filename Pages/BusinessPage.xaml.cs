namespace BizClient.Pages;

[QueryProperty(nameof(Business), "Business")]
public partial class BusinessPage : ContentPage
{
    public BusinessPage()
    {
        InitializeComponent();
    }

    private Business business;
    public Business Business
    {
        set
        {
            BindingContext = new BusinessPageViewModel(value);
        }
    }

}
