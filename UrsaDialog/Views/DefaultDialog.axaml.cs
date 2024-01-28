using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using UrsaDialog.ViewModels;

namespace UrsaDialog.Views;

public partial class DefaultDialog : UserControl
{
    public DefaultDialog()
    {
        InitializeComponent();
        this.DataContext = new DefaultDialogViewModel();
    }
}