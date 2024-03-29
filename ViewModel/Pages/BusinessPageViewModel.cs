﻿namespace BizClient.ViewModel;

public partial class BusinessPageViewModel : BaseViewModel
{

    public enum BusinessPageTabs
    {
        Info,
        Posts
    }

    public BusinessPageViewModel(Business business)
    {
        this.Business = business;
        this.Palette = Business.Theme.Key != null ? BusinessPalettes.Palettes.Find(_ => _.Key == this.Business.Theme.Key) : BusinessPalettes.Palettes[0];

        this.EditedInfo = CloneHelper.Clone<BusinessInfo>(Business.Info);
        this.postService = Store.ServicesStore.PostService;
        this.businessService = Store.ServicesStore.BusinessService;
        this.subscriptionService = Store.ServicesStore.SubscriptionService;
        this.chatService = Store.ServicesStore.ChatService;
        this.fileService = Store.ServicesStore.FileService;
        initPage();
    }

    async public void initPage()
    {
        IsLoading = true;
        this.subscription = await this.subscriptionService.getSubscription(Store.UserId, Business.Id);
        this.IsSubscribed = this.subscription != null;
        this.SubscribeButtonText = this.IsSubscribed ? "Unsubscribe" : "Subscribe";
        IsLoading = false;
    }

    private readonly PostService postService;
    private readonly BusinessService businessService;
    private readonly SubscriptionService subscriptionService;
    private readonly ChatService chatService;
    private readonly FileService fileService;
    public Subscription subscription;

    [ObservableProperty]
    public Palette palette;

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsEditVisible))]
    public bool isBusinessMode = Store.IsBusiness;
    [ObservableProperty]
    public bool isUserMode = Store.IsUser;

    [ObservableProperty]
    public Business business;

    [ObservableProperty]
    public bool isSubscribed;

    [ObservableProperty]
    public string subscribeButtonText;

    public ObservableCollection<Post> Posts { get; } = new();

    public ObservableCollection<Product> Products { get; } = new();

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsPosts))]
    [AlsoNotifyChangeFor(nameof(IsProducts))]
    public bool isInfo = true;

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsInfo))]
    [AlsoNotifyChangeFor(nameof(IsProducts))]
    public bool isPosts = false;

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsInfo))]
    [AlsoNotifyChangeFor(nameof(IsPosts))]
    public bool isProducts = false;


    [ICommand]
    public void OnInfoClick()
    {
        IsInfo = true;
        IsPosts = false;
        IsProducts = false;

    }

    [ICommand]
    async public void OnPostsClick()
    {
        IsInfo = false;
        IsPosts = true;
        IsProducts = false;

        Posts.Clear();

        this.IsLoading = true;
        var posts = await this.postService.GetBusinessPosts(business.Id);
        posts.ForEach(_ => Posts.Add(_));
        this.IsLoading = false;
    }

    [ICommand]
    async public void OnProductsClick()
    {
        IsInfo = false;
        IsPosts = false;
        IsProducts = true;

        Products.Clear();
        this.IsLoading = true;
        var products = await this.businessService.GetAllProducts(business.Id);
        products.ForEach(_ => Products.Add(_));
        this.IsLoading = false;
    }

    [ICommand]
    public async void OnMessageClick()
    {
        var chat = await chatService.GetChatByParticipants(Store.Auth.User, Business);
        await Shell.Current.GoToAsync(Routes.Chat, true, new Dictionary<string, object>
        {
            {"Chat", chat}
        });
    }

    [ICommand]
    public async void OnSubscriptionClick()
    {
        if (IsSubscribed)
        {
            await this.subscriptionService.Unsubscribe(this.subscription);
            this.IsSubscribed = false;
            this.SubscribeButtonText = "Subscribe";
        }
        else
        {
            subscription = await this.subscriptionService.Subscribe(new Subscription { Business = this.Business, User = Store.Auth.User });
            this.IsSubscribed = true;
            this.SubscribeButtonText = "Unsubscribe";
        }
    }

    #region Business

    [ObservableProperty]
    public bool isPalettePickerOpen = false;

    [ObservableProperty]
    public BusinessInfo editedInfo;

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsNotEditInfo))]
    [AlsoNotifyChangeFor(nameof(IsEditVisible))]
    public bool isEditInfo = false;

    public bool IsNotEditInfo => !isEditInfo;

    public bool IsEditVisible => IsBusinessMode && IsNotEditInfo;

    [ICommand]
    public void OnChangePaletteClick()
    {
        this.IsPalettePickerOpen = true;
    }

    [ICommand]
    public void OnEditInfoClick()
    {
        this.IsEditInfo = true;
    }

    [ICommand]
    public void OnCancelEdit()
    {
        this.IsEditInfo = false;
        this.editedInfo = CloneHelper.Clone<BusinessInfo>(Business.Info);
    }

    [ICommand]
    public async void OnDeleteImageClick(string imageUrl)
    {
        var IsConfirmed = await Shell.Current.DisplayAlert("Delte confirmation", "Are you sure?", "Yes", "Cancel");

        if (IsConfirmed)
        {
            this.Business = await businessService.DeleteBusinessImage(this.Business.Id, imageUrl);
            Store.Auth.Business = this.Business;
        }
    }

    [ICommand]
    public async void OnUploadImageClick()
    {
        var pickedImage = await FilePicker.PickAsync();
        if (pickedImage != null)
        {
            if (pickedImage.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                pickedImage.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase) ||
                pickedImage.FileName.EndsWith("jpeg", StringComparison.OrdinalIgnoreCase))
            {
                var imageUrl = await this.fileService.UploadImage(pickedImage.FullPath);
                this.Business = await businessService.AddBusinessImage(this.Business.Id, imageUrl);
                Store.Auth.Business = this.Business;
            }
        }
    }

    [ICommand]
    public async void OnSaveEdit()
    {
        var IsConfirmed = await Shell.Current.DisplayAlert("Edit confirmation", "Please confirm your changes", "Confirm", "Cancel");

        if (IsConfirmed)
        {
            this.IsEditInfo = false;
            this.Business.Info = CloneHelper.Clone<BusinessInfo>(EditedInfo);
            this.Business = CloneHelper.Clone<Business>(this.Business);
            var updatedBusiness = await businessService.UpdateBusiness(Business);
            Store.Auth.Business = updatedBusiness;
        }
    }

    public async void OnApplyPalette(Palette palette)
    {
        this.IsPalettePickerOpen = false;
        this.Palette = palette;
        var updatedBusiness = await this.businessService.UpdateBusinessTheme(Business.Id, Palette.Key);
        Store.Auth.Business = Business = updatedBusiness;
    }

    #endregion
}
