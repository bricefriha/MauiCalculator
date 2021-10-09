using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace MauiCalculator
{
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
                    fonts.AddFont("FontAwesome5Brands-Regular-400.otf", "BrandIcon");
                    fonts.AddFont("FontAwesome5Free-Regular-400.otf", "RegularIcon");
                    fonts.AddFont("FontAwesome5Free-Solid-900.otf", "SolidIcon");
                });

            return builder.Build();
        }
    }
}