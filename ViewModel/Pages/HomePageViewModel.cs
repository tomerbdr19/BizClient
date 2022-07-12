namespace BizClient.ViewModel;

public partial class HomePageViewModel : BaseViewModel
{

    public HomePageViewModel()
    {
        foreach (Post post in Mocks.posts)
        {
            Posts.Add(post);
        }
    }

    public ObservableCollection<Post> Posts { get; } = new();

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }
}