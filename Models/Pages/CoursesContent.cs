using TravellersTavern.Models.Blocks;

namespace TravellersTavern.Models.Pages;

public class CoursesContent
{
    public string Title { get; set; } = "";
    public string IntroText { get; set; } = "";
    public List<CourseOptionBlock> Options { get; set; } = new();
    public string CalendarNote { get; set; } = "";
}
