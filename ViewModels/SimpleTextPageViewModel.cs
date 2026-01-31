using CommunityToolkit.Mvvm.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace TravellersTavern.ViewModels;

public partial class SimpleTextPageViewModel : BaseViewModel
{
    [ObservableProperty] private string title = "";
    [ObservableProperty] private string text = "";

    public void Set(string title, string text)
    {
        Title = title;
        Text = text;
    }
}
