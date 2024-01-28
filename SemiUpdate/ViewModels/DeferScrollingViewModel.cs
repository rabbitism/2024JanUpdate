using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SemiUpdate.ViewModels;

public class DeferScrollingViewModel: ObservableObject
{
    public ObservableCollection<string> Data { get; set; }

    public DeferScrollingViewModel()
    {
        Data = new ObservableCollection<string>();
        for (var i = 0; i < 1000; i++)
        {
            Data.Add("Item " + i);
        }
    }
}