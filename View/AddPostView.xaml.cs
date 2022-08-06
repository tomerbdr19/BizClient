namespace BizClient.View;

public partial class AddPostView
{
	public AddPostView()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty TokenProperty =
    BindableProperty.Create(
    nameof(Token),
    typeof(string),
    typeof(AddPostView));

    public string Token
    {
        get { return (string)GetValue(TokenProperty); }
        set { SetValue(TokenProperty, value); }
    }

    [ObservableProperty]
    private String content = "";

    [ObservableProperty]
    private ImageSource image;


    [ICommand]
    async Task OnAddPictureClick()
    {
        var result = await FilePicker.PickAsync();
        if (result != null)
        {
            if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                result.FileName.EndsWith("jpeg", StringComparison.OrdinalIgnoreCase) ||
                result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
            {
                var stream = await result.OpenReadAsync();
                Image = ImageSource.FromStream(() => stream);
            }
            else
            {
                //TODO hnadle ERROR 
            }
        }
        else
        {
            //TODO hnadle ERROR 
        }
    }

    [ICommand]
    async Task OnPublishClick()
    {
        //TODO
    }
}