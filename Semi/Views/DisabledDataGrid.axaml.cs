using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Semi.ViewModels;

namespace Semi.Views;

public partial class DisabledDataGrid : UserControl
{
    public DisabledDataGrid()
    {
        InitializeComponent();
        this.DataContext = new DisabledDataGridViewModel();
    }
}