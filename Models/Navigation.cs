namespace TravellersTavern.Models;

public class Navigation
{
    public List<NavItem> Primary { get; set; } = new();
}

public class NavItem
{
    public string Title { get; set; } = "";
    public string? Href { get; set; }
    public List<NavItem>? Children { get; set; }
}
