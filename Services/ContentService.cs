using System.Text.Json;
using TravellersTavern.Models.Pages;
using TravellersTavern.Models;

namespace TravellersTavern.Services;

public class ContentService : IContentService
{
    private readonly ContentRoot _root;

    public ContentService(IWebHostEnvironment env)
    {
        var path = Path.Combine(env.ContentRootPath, "Data", "content.json");
        var json = File.ReadAllText(path);

        _root = JsonSerializer.Deserialize<ContentRoot>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? new ContentRoot();

    }

    public string OrganizationName => _root.OrganizationName;
    public Navigation Navigation => _root.Navigation;
    public FooterInfo Footer => _root.Footer;

    public HomeContent Home => _root.Pages.Home;
    public PublicGamesContent PublicGames => _root.Pages.PublicGames;
    public CoursesContent Courses => _root.Pages.Courses;
    public PrivateSessionContent PrivateSession => _root.Pages.PrivateSession;
    public SimpleTextContent About => _root.Pages.About;
    public SimpleTextContent Terms => _root.Pages.Terms;

    private class ContentRoot
    {
        public string OrganizationName { get; set; } = "The Traveller's Tavern";
        public Navigation Navigation { get; set; } = new();
        public FooterInfo Footer { get; set; } = new();
        public PagesRoot Pages { get; set; } = new();
    }

    private class PagesRoot
    {
        public HomeContent Home { get; set; } = new();
        public PublicGamesContent PublicGames { get; set; } = new();
        public CoursesContent Courses { get; set; } = new();
        public PrivateSessionContent PrivateSession { get; set; } = new();
        public SimpleTextContent About { get; set; } = new();
        public SimpleTextContent Terms { get; set; } = new();
    }
}
