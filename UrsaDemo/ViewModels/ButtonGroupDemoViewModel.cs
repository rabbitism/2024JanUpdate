using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ursa.Controls;

namespace UrsaDemo.ViewModels;

public class ButtonGroupDemoViewModel:ObservableObject
{
    public ObservableCollection<ButtonItem> Items { get; set; } = new()
    {
        new ButtonItem("Ding"),
        new ButtonItem("Otter"),
        new ButtonItem("Husky"),
        new ButtonItem("Mr. 17"),
        new ButtonItem("Cass"),
    };
}

public class ButtonItem
{
    public string? Content { get; set; }
    
    public ICommand Command { get; set; }

    public ButtonItem(string? content)
    {
        Content = content;
        Command = new AsyncRelayCommand(ShowMessageAsync);
    }

    private async Task ShowMessageAsync()
    {
        await MessageBox.ShowAsync("Hello " + Content);
    }
}