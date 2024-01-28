using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using UrsaDemo.ViewModels;

namespace UrsaDemo.Views;

public partial class TimelineDemo : UserControl
{
    public TimelineDemo()
    {
        InitializeComponent();
        this.DataContext = new TimelineDemoViewModel();
    }
}