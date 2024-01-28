using CommunityToolkit.Mvvm.ComponentModel;

namespace UrsaDialog.Dialogs;

public partial class FlatDialogViewModel: ObservableObject
{
    [ObservableProperty] private int _score;
}