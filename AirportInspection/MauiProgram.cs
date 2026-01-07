using AirportInspection.Services;
using Microsoft.Extensions.Logging;

namespace AirportInspection
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

            // Registering services and view models for dependency injection
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<ViewModels.MainPageViewModel>();

            // Database initialisation
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "inspections.db3");
            builder.Services.AddSingleton(
                new InspectionDatabase(dbPath)
            );

            return builder.Build();
        }
    }
}
