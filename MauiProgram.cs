using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.DataGrid.Hosting;
using ZXing.Net.Maui;

namespace BizClient;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseBarcodeReader()
            .ConfigureSyncfusionCore()
            .ConfigureSyncfusionDataGrid()
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
        builder.Services.AddSingleton<ChatsPage>();
        builder.Services.AddSingleton<UserRegisterPage>();
        builder.Services.AddSingleton<BusinessesRegistrationPage>();

        builder.Services.AddSingleton<AdminHomePage>();
        builder.Services.AddSingleton<QRScannerPage>();

        // View Models
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<BusinessesPageViewModel>();
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddSingleton<CouponsPageViewModel>();
        builder.Services.AddSingleton<UserRegisterViewModel>();
        builder.Services.AddSingleton<BusinessesRegistrationViewModel>();
        builder.Services.AddSingleton<ChatsPageViewModel>();

        builder.Services.AddSingleton<AdminHomePageViewModel>();
        builder.Services.AddSingleton<QRScannerPageViewModel>();

        // Dekstop Business Pages
        builder.Services.AddSingleton<BusinessHomePage>();
        builder.Services.AddSingleton<BusinessSubscribersPage>();
        builder.Services.AddSingleton<BusinessDiscountsPage>();

        // Desktop View Models
        builder.Services.AddSingleton<BusinessHomePageViewModel>();
        builder.Services.AddSingleton<BusinessSubscribersPageViewModel>();
        builder.Services.AddSingleton<BusinessDiscountsPageViewModel>();



        return builder.Build();
    }
}
