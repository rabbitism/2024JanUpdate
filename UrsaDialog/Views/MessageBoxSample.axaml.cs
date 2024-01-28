using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using UrsaDialog.ViewModels;

namespace UrsaDialog.Views;

public partial class MessageBoxSample : UserControl
{
    public MessageBoxSample()
    {
        InitializeComponent();
        this.DataContext = new MessageBoxSampleViewModel();
    }
}