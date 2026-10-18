using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Voxsign1.Views;

namespace Voxsign1.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    private string email = "danielacledya@gmail.fr";

    [ObservableProperty]
    private string password = "";

    [RelayCommand]
    private async Task LoginAsync()
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    [RelayCommand]
    private async Task GoToRegisterAsync()
    {
        await Shell.Current.GoToAsync(nameof(RegisterPage));
    }

    [RelayCommand]
    private async Task ExploreWithoutAccountAsync()
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}