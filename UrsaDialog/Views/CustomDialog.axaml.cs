using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using UrsaDialog.ViewModels;

namespace UrsaDialog.Views;

public partial class CustomDialog : UserControl
{
    public CustomDialog()
    {
        InitializeComponent();
        this.DataContext = new CustomDialogViewModel();
    }
}