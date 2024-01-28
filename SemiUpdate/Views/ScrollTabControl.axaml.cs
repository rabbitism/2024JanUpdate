using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SemiUpdate.ViewModels;

namespace SemiUpdate.Views;

public partial class ScrollTabControl : UserControl
{
    public ScrollTabControl()
    {
        InitializeComponent();
        this.DataContext = new TabControlViewModel();
    }
}