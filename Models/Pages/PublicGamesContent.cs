using TravellersTavern.Models.Blocks;

namespace TravellersTavern.Models.Pages;

public class PublicGamesContent
{
    public string Title { get; set; } = "";
    public string IntroText { get; set; } = "";

    public string? HeroImageUrl { get; set; }

    public List<LocationBlock> Locations { get; set; } = new();
}
