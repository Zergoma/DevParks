using DevsPark.MVVM.Pages.DesertMirage.NightAdventures;
using DevsPark.MVVM.ViewModels;
using Microsoft.Extensions.Logging;

namespace DevParks
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<NightDuneBuggy>();
            builder.Services.AddTransient<PlacesViewModel>();

            return builder.Build();
        }
    }
}
