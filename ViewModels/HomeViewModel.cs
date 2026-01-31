using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using TravellersTavern.Models.Blocks;   
using TravellersTavern.Services;   

namespace TravellersTavern.ViewModels;

public partial class HomeViewModel : BaseViewModel
{
    private readonly IContentService _content;
    private readonly NavigationManager _nav;

    public HomeViewModel(IContentService content, NavigationManager nav)
    {
        _content = content;
        _nav = nav;
    }

    [ObservableProperty] private string title = "";
    [ObservableProperty] private string introText = "";

    public IReadOnlyList<ChoiceCard> ChoiceCards { get; private set; } = Array.Empty<ChoiceCard>();

    public void Load()
    {
        var page = _content.Home;
        Title = page.Title;
        IntroText = page.IntroText;
        ChoiceCards = page.ChoiceCards;
        OnPropertyChanged(nameof(ChoiceCards));
    }

    [RelayCommand]
    private void NavigateTo(string href)
    {
        if (string.IsNullOrWhiteSpace(href)) return;
        _nav.NavigateTo(href);
    }
}
