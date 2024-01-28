using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SemiUpdate.ViewModels;

namespace SemiUpdate.Views;

public partial class DeferScrolling : UserControl
{
    public DeferScrolling()
    {
        InitializeComponent();
        this.DataContext = new DeferScrollingViewModel();
    }
}