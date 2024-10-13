using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaTodoList.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string greeting = "Welcome to 123 Avaloniaaa!";
}
