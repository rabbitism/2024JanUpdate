using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Semi.Views;

public partial class CalendarDatePickerIssue : UserControl
{
    public CalendarDatePickerIssue()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        datePicker.SelectedDate = DateTime.Today;
    }
}