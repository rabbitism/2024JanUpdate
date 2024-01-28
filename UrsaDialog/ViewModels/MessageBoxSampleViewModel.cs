using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ursa.Common;
using Ursa.Controls;

namespace UrsaDialog.ViewModels;

public partial class MessageBoxSampleViewModel: ObservableObject
{
    public ICommand ShowMessageCommand { get; set; }
    public ICommand CustomCommand { get; set; }
    
    [ObservableProperty] private MessageBoxButton _selectedButton;
    [ObservableProperty] private MessageBoxIcon _selectedIcon;
    [ObservableProperty] private MessageBoxResult? _result;
    [ObservableProperty] private string? _title;
    [ObservableProperty] private string? _message;

    public MessageBoxSampleViewModel()
    {
        ShowMessageCommand = new AsyncRelayCommand(ShowMessageAsync);
        CustomCommand = new AsyncRelayCommand(ShowCustomAsync);
    }

    private async Task ShowCustomAsync()
    {
        Result = await MessageBox.ShowAsync(Message, Title, SelectedIcon, SelectedButton);
    }

    private async Task ShowMessageAsync()
    {
        await MessageBox.ShowAsync("Hello Ursa Avalonia!");
    }
    
    
}