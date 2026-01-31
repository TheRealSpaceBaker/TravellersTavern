using CommunityToolkit.Mvvm.ComponentModel;
using TravellersTavern.Models.Blocks;
using TravellersTavern.Services;

namespace TravellersTavern.ViewModels;

public partial class HomeViewModel : BaseViewModel
{
    private readonly IContentService _content;

    public HomeViewModel(IContentService content)
    {
        _content = content;
    }

    [ObservableProperty] private string title = "";
    [ObservableProperty] private string introText = "";
    [ObservableProperty] private string? heroImageUrl;

    public IReadOnlyList<ChoiceCard> ChoiceCards { get; private set; } = Array.Empty<ChoiceCard>();

    public void Load()
    {
        var page = _content.Home;
        Title = page.Title;
        IntroText = page.IntroText;
        HeroImageUrl = page.HeroImageUrl;

        ChoiceCards = page.ChoiceCards;
        OnPropertyChanged(nameof(ChoiceCards));
    }
}
