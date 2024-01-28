using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using UrsaDialog.ViewModels;

namespace UrsaDialog.Views;

public partial class OverlayDialogDemo : UserControl
{
    public OverlayDialogDemo()
    {
        InitializeComponent();
        this.DataContext = new OverlayDialogDemoViewModel();
    }
}