using MiChatGpt.Services;
using MiChatGpt.Services.Interfaces;
using MiChatGpt.ViewModels;
using MiChatGpt.Views;
using Microsoft.Extensions.Logging;

namespace MiChatGpt
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
            //Primer la página
            builder.Services.AddSingleton<MainPage>();
            //ViewModel
            builder.Services.AddSingleton<MainPageViewModel>();
            //Interfaz, servicio
            builder.Services.AddSingleton<IMensajeria, Mensajeria>();
            return builder.Build();
        }
    }
}