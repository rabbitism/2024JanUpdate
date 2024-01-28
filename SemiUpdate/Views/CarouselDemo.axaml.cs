using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SemiUpdate.Views;

public partial class CarouselDemo : UserControl
{
    public CarouselDemo()
    {
        InitializeComponent();
    }

    private void TextBox_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        Carousel.Classes.Clear();
        Carousel.Classes.AddRange((sender as TextBox).Text.Split(" "));
    }
}