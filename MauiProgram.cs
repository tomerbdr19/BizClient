using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
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
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<CouponsPage>();

        // Views

        // View Models
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<BusinessesPageViewModel>();
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddSingleton<CouponsPageViewModel>();

        //builder.Services.AddSingleton<CouponCartesianChartViewModel>();

        return builder.Build();
    }
}
