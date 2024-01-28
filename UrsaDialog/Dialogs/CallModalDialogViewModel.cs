using System;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ursa.Controls;

namespace UrsaDialog.Dialogs;

public partial class CallModalDialogViewModel: ObservableObject, IDialogContext
{
    public ICommand ShowDialogCommand { get; set; }
    public ICommand ConfirmCommand { get; set; }

    public CallModalDialogViewModel()
    {
        ShowDialogCommand = new AsyncRelayCommand(ShowDialogAsync);
        ConfirmCommand = new RelayCommand(Confirm);
    }

    private void Confirm()
    {
        RequestClose?.Invoke(this, true);
    }

    private async Task ShowDialogAsync()
    {
        await OverlayDialog.ShowCustomModalAsync<CallModalDialog, CallModalDialogViewModel, bool>(
            new CallModalDialogViewModel());
    }

    public void Close()
    {
        RequestClose?.Invoke(this, false);
    }

    public event EventHandler<object?>? RequestClose;
}