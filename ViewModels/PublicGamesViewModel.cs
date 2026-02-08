using CommunityToolkit.Mvvm.ComponentModel;
using TravellersTavern.Models.Blocks;
using TravellersTavern.Services;

namespace TravellersTavern.ViewModels;

public partial class PublicGamesViewModel : BaseViewModel
{
    private readonly IContentService _content;

    public PublicGamesViewModel(IContentService content) => _content = content;

    [ObservableProperty] private string title = "";
    [ObservableProperty] private string introText = "";
    [ObservableProperty] private string? heroImageUrl;

    public IReadOnlyList<LocationBlock> Locations { get; private set; } = Array.Empty<LocationBlock>();

    public void Load()
    {
        var page = _content.PublicGames;
        Title = page.Title;
        IntroText = page.IntroText;
        HeroImageUrl = page.HeroImageUrl;

        Locations = page.Locations;
        OnPropertyChanged(nameof(Locations));
    }
}
