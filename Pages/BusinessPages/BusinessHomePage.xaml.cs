namespace BizClient.Pages.BusinessPages;

public partial class BusinessHomePage : ContentPage
{
    public BusinessHomePage(BusinessHomePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        this.viewModel = viewModel;

        modal.IsVisible = false;
        PublishPostFrame.IsVisible = false;
        PublishPost.IsVisible = false;
        AnnounceFrame.IsVisible = false;
        Announce.IsVisible = false;
    }

    public BusinessHomePageViewModel viewModel;

    protected override void OnAppearing() {
        viewModel.OnAppearing();
    }

    [ICommand]
    public void OnQuickActionClick(string action)
    {
        modal.IsVisible = true;
        switch (action)
        {
            case ("post"):
                PublishPostFrame.IsVisible = true;
                PublishPost.IsVisible = true;
                break;
            case ("annonce"):
                AnnounceFrame.IsVisible = true;
                Announce.IsVisible = true;
                break;
        }
        
    }

    [ICommand]
    public void OnCloseModalClick()
    {
        modal.IsVisible = false;
        PublishPostFrame.IsVisible = false;
        PublishPost.IsVisible = false;
        AnnounceFrame.IsVisible = false;
        Announce.IsVisible = false;
    }
}
