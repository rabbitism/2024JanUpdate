using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ursa.Controls;
using UrsaDialog.Dialogs;

namespace UrsaDialog.ViewModels;

public class OverlayDialogDemoViewModel: ObservableObject
{
    public ICommand ShowDefaultModalCommand { get; set; }
    public ICommand ShowCustomModalCommand { get; set; }
    public ICommand ShowDefaultCommand { get; set; }
    public ICommand ShowCustomCommand { get; set; }
    public ICommand ShowLocalModalCommand { get; set; }
    public ICommand ShowLocalCommand { get; set; }
    public ICommand ShowMessageBoxCommand { get; set; }

    public OverlayDialogDemoViewModel()
    {
        ShowDefaultModalCommand = new AsyncRelayCommand(ShowDefaultModalAsync);
        ShowCustomModalCommand = new AsyncRelayCommand(ShowCustomModalAsync);
        ShowDefaultCommand = new RelayCommand(ShowDefault);
        ShowCustomCommand = new RelayCommand(ShowCustom);
        ShowLocalModalCommand = new AsyncRelayCommand(ShowLocalModal);
        ShowLocalCommand = new RelayCommand(ShowLocal);
        ShowMessageBoxCommand = new AsyncRelayCommand(ShowMessageBoxAsync);
    }

    private async Task ShowMessageBoxAsync()
    {
        await MessageBox.ShowOverlayAsync("Hello Ursa Avalonia!", "Ursa", icon: MessageBoxIcon.Success,
            button: MessageBoxButton.YesNoCancel);
    }

    private void ShowLocal()
    {
        OverlayDialog.Show<FlatDialog, FlatDialogViewModel>(new FlatDialogViewModel(), hostId: "Local");
    }

    private async Task ShowLocalModal()
    {
        await OverlayDialog.ShowModalAsync<FlatDialog, FlatDialogViewModel>(new FlatDialogViewModel(), hostId: "Local");
    }

    private void ShowCustom()
    {
        OverlayDialog.ShowCustom<SpecialDialog, SpecialDialogViewModel>(new SpecialDialogViewModel());
    }

    private void ShowDefault()
    {
        OverlayDialog.Show<FlatDialog, FlatDialogViewModel>(new FlatDialogViewModel());
    }

    private Task ShowCustomModalAsync()
    {
        return OverlayDialog.ShowCustomModalAsync<SpecialDialog, SpecialDialogViewModel, object?>(new SpecialDialogViewModel());
    }

    private async Task ShowDefaultModalAsync()
    {
        await OverlayDialog.ShowModalAsync<FlatDialog, FlatDialogViewModel>(new FlatDialogViewModel());
    }
}