using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SemiUpdate.ViewModels;

namespace SemiUpdate.Views;

public partial class DisabledDataGrid : UserControl
{
    public DisabledDataGrid()
    {
        InitializeComponent();
        this.DataContext = new DisabledDataGridViewModel();
    }
}