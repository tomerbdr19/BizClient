using SkiaSharp.Views.Maui.Controls.Hosting;

namespace BizClient;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseSkiaSharp(true)
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
        builder.Services.AddSingleton<CustomerRegistrationPage>();
        builder.Services.AddSingleton<BusinessesRegistrationPage>();

        // Views

        // View Models
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<BusinessesPageViewModel>();
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddSingleton<CouponsPageViewModel>();
        builder.Services.AddSingleton<CustomerRegistrationViewModel>();
        builder.Services.AddSingleton<BusinessesRegistrationViewModel>();

        return builder.Build();
    }
}
