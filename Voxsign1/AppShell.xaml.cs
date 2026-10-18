using Voxsign1.Views;

namespace Voxsign1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Enregistrement des routes secondaires
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(TextToSignPage), typeof(TextToSignPage));
        Routing.RegisterRoute(nameof(VoiceToTextPage), typeof(VoiceToTextPage));
        Routing.RegisterRoute(nameof(SignSequencePage), typeof(SignSequencePage));
        Routing.RegisterRoute(nameof(SignDetailPage), typeof(SignDetailPage));
        Routing.RegisterRoute(nameof(UsefulPhrasesPage), typeof(UsefulPhrasesPage));
        Routing.RegisterRoute(nameof(OfflinePacksPage), typeof(OfflinePacksPage));
    }
}