using TravellersTavern.Models.Pages;
using TravellersTavern.Models;

namespace TravellersTavern.Services;

public interface IContentService
{
    string OrganizationName { get; }
    Navigation Navigation { get; }
    FooterInfo Footer { get; }

    HomeContent Home { get; }
    PublicGamesContent PublicGames { get; }
    CoursesContent Courses { get; }
    PrivateSessionContent PrivateSession { get; }
    SimpleTextContent About { get; }
    SimpleTextContent Terms { get; }

}
