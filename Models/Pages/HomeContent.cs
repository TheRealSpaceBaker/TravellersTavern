using TravellersTavern.Models.Blocks;

namespace TravellersTavern.Models.Pages;

public class HomeContent
{
    public string Title { get; set; } = "";
    public string IntroText { get; set; } = "";
    public string? HeroImageUrl { get; set; }

    public List<ChoiceCard> ChoiceCards { get; set; } = new();
}
