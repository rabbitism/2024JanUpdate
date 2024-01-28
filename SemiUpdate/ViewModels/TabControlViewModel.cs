using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SemiUpdate.ViewModels;

public class TabControlViewModel: ObservableObject
{
    public ObservableCollection<TabItemViewMode> Items { get; set; }

    public TabControlViewModel()
    {
        Items = new ObservableCollection<TabItemViewMode>();
        for (int i = 0; i < 100; i++)
        {
            Items.Add(new TabItemViewMode()
            {
                Header = $"Tab{i}",
                Content = $"Content{i}"
            });
        }
    }
}

public class TabItemViewMode
{
    public string? Header { get; set; }
    public string? Content { get; set; }
}