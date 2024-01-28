using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ursa.Common;
using Ursa.Controls;
using UrsaDialog.Dialogs;

namespace UrsaDialog.ViewModels;

public partial class DefaultDialogViewModel: ObservableObject
{
    public ICommand DefaultCommand { get; set; }
    public ICommand CustomCommand { get; set; }
    [ObservableProperty] private DialogButton _selectedButton;
    [ObservableProperty] private DialogMode _selectedMode;
    [ObservableProperty] private DialogResult? _result;
    
    [ObservableProperty] private int _score;
    
    public DefaultDialogViewModel()
    {
        DefaultCommand = new AsyncRelayCommand(DefaultAsync);
        CustomCommand = new AsyncRelayCommand(CustomAsync);
    }
    
    private async Task CustomAsync()
    {
        var vm = new FlatDialogViewModel() { Score = Score };
        Result = await Dialog.ShowModalAsync<FlatDialog, FlatDialogViewModel>(vm,
            mode: SelectedMode, buttons: SelectedButton);
    }

    private async Task DefaultAsync()
    {
        await Dialog.ShowModalAsync<FlatDialog, FlatDialogViewModel>(new FlatDialogViewModel() { Score = 88 });
    }
}