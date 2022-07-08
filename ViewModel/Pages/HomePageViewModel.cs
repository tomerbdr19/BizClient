namespace BizClient.ViewModel;

public partial class HomePageViewModel : BaseViewModel
{

    public HomePageViewModel()
    {
        Posts.Add(new Post(new PostResponse()));
        Posts.Add(new Post(new PostResponse()));
        Posts.Add(new Post(new PostResponse()));
    }

    public ObservableCollection<Post> Posts { get; } = new();

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }
}