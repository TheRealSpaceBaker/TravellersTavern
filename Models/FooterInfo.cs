namespace TravellersTavern.Models;

public class FooterInfo
{
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public string Address { get; set; } = "";
    public string KvkNumber { get; set; } = "";
    public List<SocialLink> Socials { get; set; } = new();
}

public class SocialLink
{
    public string Name { get; set; } = "";
    public string Url { get; set; } = "";
}
