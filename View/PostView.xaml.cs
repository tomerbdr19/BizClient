namespace BizClient.View;

public partial class PostView
{

    public PostView()
    {
        InitializeComponent();
        postService = Store.ServicesStore.PostService;
        deleteButton.IsVisible = Store.IsBusiness;
    }

    private readonly PostService postService;

    public static readonly BindableProperty PostProperty =
        BindableProperty.Create(nameof(Post), typeof(Post), typeof(PostView), default(Post), propertyChanged: (sender, old, newobj) =>
        {
            if (newobj != null)
            {
                ((PostView)sender).GetCouponButton.IsVisible = ((Post)newobj).Discount != null && Store.IsUser;
            }
        });

    public Post Post
    {
        get { return (Post)GetValue(PostProperty); }
        set { SetValue(PostProperty, value); }
    }

    [ICommand]
    async Task OnDeleteClick()
    {
        var IsConfirmed = await Shell.Current.DisplayAlert("Delete confirmation", "Please confirm the delete", "Confirm", "Cancel");
        if (IsConfirmed)
        {
            await postService.DeletePost(Post.Id);
        }
    }

    public async void OnGetCouponClick(System.Object sender, System.EventArgs e)
    {
        try
        {
            await Store.ServicesStore.CouponService.CreateCoupon(Store.UserId, this.Post.Discount);
            this.GetCouponButton.IsEnabled = false;
        }
        catch
        {
            Shell.Current.DisplayAlert("Error", "You already have this coupon.", "OK");
        }

    }
}
