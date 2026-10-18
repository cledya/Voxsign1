using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Voxsign1.Views;

namespace Voxsign1.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    private async Task GoToTextToSignAsync() => await Shell.Current.GoToAsync(nameof(TextToSignPage));

    [RelayCommand]
    private async Task GoToVoiceToTextAsync() => await Shell.Current.GoToAsync(nameof(VoiceToTextPage));

    [RelayCommand]
    private async Task GoToUsefulPhrasesAsync() => await Shell.Current.GoToAsync(nameof(UsefulPhrasesPage));

    [RelayCommand]
    private async Task GoToChatAsync() => await Shell.Current.GoToAsync("//ChatPage");

    [RelayCommand]
    private async Task GoToOfflinePacksAsync() => await Shell.Current.GoToAsync(nameof(OfflinePacksPage));
}