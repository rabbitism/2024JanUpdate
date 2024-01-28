using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using UrsaDemo.ViewModels;

namespace UrsaDemo.Views;

public partial class ButtonGroupDemo : UserControl
{
    public ButtonGroupDemo()
    {
        InitializeComponent();
        this.DataContext = new ButtonGroupDemoViewModel();
    }
}