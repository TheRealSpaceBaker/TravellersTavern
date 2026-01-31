using CommunityToolkit.Mvvm.ComponentModel;
using TravellersTavern.Models.Blocks;
using TravellersTavern.Services;
using TravellersTavern.ViewModels;

namespace TravellersTavern.ViewModels;

public partial class PublicGamesViewModel : BaseViewModel
{
    private readonly IContentService _content;

    public PublicGamesViewModel(IContentService content) => _content = content;

    [ObservableProperty] private string title = "";
    [ObservableProperty] private string introText = "";

    public IReadOnlyList<LocationBlock> Locations { get; private set; } = Array.Empty<LocationBlock>();

    public void Load()
    {
        var page = _content.PublicGames;
        Title = page.Title;
        IntroText = page.IntroText;
        Locations = page.Locations;
        OnPropertyChanged(nameof(Locations));
    }
}
