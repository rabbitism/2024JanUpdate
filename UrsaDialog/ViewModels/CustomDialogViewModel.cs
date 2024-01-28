using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ursa.Controls;
using UrsaDialog.Dialogs;

namespace UrsaDialog.ViewModels;

public partial class CustomDialogViewModel: ObservableObject
{
    public ICommand DefaultCommand { get; set; }
    [ObservableProperty] private bool? _result;

    public CustomDialogViewModel()
    {
        DefaultCommand = new AsyncRelayCommand(DefaultAsync);
    }

    private async Task DefaultAsync()
    {
        Result = await Dialog.ShowCustomModalAsync<SpecialDialog, SpecialDialogViewModel, bool>(new SpecialDialogViewModel());
    }
}