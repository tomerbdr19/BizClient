namespace BizClient.View;

public partial class AnnounceView : Frame
{
	public AnnounceView()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty ContentAnnounceProperty =
                   BindableProperty.Create(nameof(ContentAnnounce),
                                          typeof(string),
                                          typeof(AnnounceView));

    public string ContentAnnounce
    {
        get { return (string)GetValue(ContentAnnounceProperty); }
        set { SetValue(ContentAnnounceProperty, value); }
    }


    [ICommand]
    async Task OnAnnounceClick()
    {
        //TODO
    }
}