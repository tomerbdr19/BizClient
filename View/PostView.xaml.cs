namespace BizClient.View;

public partial class PostView
{

    public PostView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty BusinessNameProperty =
    BindableProperty.Create(
        nameof(BusinessName),
        typeof(string),
        typeof(PostView));

    public string BusinessName
    {
        get { return (string)GetValue(BusinessNameProperty); }
        set { SetValue(BusinessNameProperty, value); }
    }

    public static readonly BindableProperty BusinessImageUrlProperty =
    BindableProperty.Create(
        nameof(BusinessImageUrl),
        typeof(string),
        typeof(PostView));

    public string BusinessImageUrl
    {
        get { return (string)GetValue(BusinessImageUrlProperty); }
        set { SetValue(BusinessImageUrlProperty, value); }
    }

    public static readonly BindableProperty CaptionProperty =
    BindableProperty.Create(
        nameof(Caption),
        typeof(string),
        typeof(PostView));

    public string Caption
    {
        get { return (string)GetValue(CaptionProperty); }
        set { SetValue(CaptionProperty, value); }
    }

    public static readonly BindableProperty ImageUrlProperty =
    BindableProperty.Create(
        nameof(ImageUrl),
        typeof(string),
        typeof(PostView));

    public string ImageUrl
    {
        get { return (string)GetValue(ImageUrlProperty); }
        set { SetValue(ImageUrlProperty, value); }
    }

    public static readonly BindableProperty CreatedAtProperty =
    BindableProperty.Create(
        nameof(CreatedAt),
        typeof(DateTime),
        typeof(PostView));

    public DateTime CreatedAt
    {
        get { return (DateTime)GetValue(CreatedAtProperty); }
        set { SetValue(CreatedAtProperty, value); }
    }
}
