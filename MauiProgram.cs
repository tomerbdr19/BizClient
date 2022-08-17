using BizClient.ViewModel.Pages;

namespace BizClient;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Pages
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<BusinessesPage>();
        builder.Services.AddSingleton<BusinessPage>();
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<CouponsPage>();
        builder.Services.AddSingleton<ChatPage>();
        builder.Services.AddSingleton<UserRegisterPage>();
        builder.Services.AddSingleton<BusinessesRegistrationPage>();

        builder.Services.AddSingleton<AdminHomePage>();
        builder.Services.AddSingleton<AdminChatPage>();
        builder.Services.AddSingleton<QRScannerPage>();

        // Views

        // View Models
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<BusinessesPageViewModel>();
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddSingleton<CouponsPageViewModel>();
        builder.Services.AddSingleton<UserRegisterViewModel>();
        builder.Services.AddSingleton<BusinessesRegistrationViewModel>();

        builder.Services.AddSingleton<AdminHomePageViewModel>();
        builder.Services.AddSingleton<AdminChatPageViewModel>();
        builder.Services.AddSingleton<QRScannerPageViewModel>();

        return builder.Build();
    }
}
