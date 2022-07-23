namespace BizClient.Pages;

[QueryProperty(nameof(Business), "Business")]
public partial class BusinessPage : ContentPage
{
    public BusinessPage(PostService postService)
    {
        InitializeComponent();
        this.postService = postService;
    }

    private readonly PostService postService;
    private Business business;
    public Business Business
    {
        set
        {
            BindingContext = new BusinessPageViewModel(value, postService);
        }
    }

}
