using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Voxsign1.ViewModels;
using Voxsign1.Views;

namespace Voxsign1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // Enregistrement des ViewModels et Vues pour l'injection de dépendances
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<LoginPage>();

        builder.Services.AddSingleton<RegisterViewModel>();
        builder.Services.AddSingleton<RegisterPage>();

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddSingleton<TextToSignViewModel>();
        builder.Services.AddSingleton<TextToSignPage>();

        builder.Services.AddSingleton<VoiceToTextViewModel>();
        builder.Services.AddSingleton<VoiceToTextPage>();

        builder.Services.AddSingleton<SignSequenceViewModel>();
        builder.Services.AddSingleton<SignSequencePage>();

        builder.Services.AddSingleton<DictionaryViewModel>();
        builder.Services.AddSingleton<DictionaryPage>();

        builder.Services.AddSingleton<SignDetailPage>();

        builder.Services.AddSingleton<UsefulPhrasesViewModel>();
        builder.Services.AddSingleton<UsefulPhrasesPage>();

        builder.Services.AddSingleton<FavoritesViewModel>();
        builder.Services.AddSingleton<FavoritesPage>();

        builder.Services.AddSingleton<OfflinePacksViewModel>();
        builder.Services.AddSingleton<OfflinePacksPage>();

        builder.Services.AddSingleton<ChatViewModel>();
        builder.Services.AddSingleton<ChatPage>();

        return builder.Build();
    }
}