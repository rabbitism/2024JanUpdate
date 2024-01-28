using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ursa.Controls;

namespace UrsaDialog.Dialogs;

public class SpecialDialogViewModel: ObservableObject, IDialogContext
{
    public ICommand ThanksCommand { get; set; }

    public SpecialDialogViewModel()
    {
        ThanksCommand = new RelayCommand(Thanks);
    }

    private void Thanks()
    {
        RequestClose?.Invoke(this, true);
    }

    public void Close()
    {
        RequestClose?.Invoke(this, false);

    }

    public event EventHandler<object?>? RequestClose;
}