namespace BizClient.Pages;

public partial class ChatsPage : ContentPage
{
	public ChatsPage(ChatsPageViewModel viewModel)
	{
		InitializeComponent();
        this.viewModel = viewModel;
        BindingContext = viewModel;
    }

    private ChatsPageViewModel viewModel { get; set; }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.OnAppearing();
    }

}