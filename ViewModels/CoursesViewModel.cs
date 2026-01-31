using CommunityToolkit.Mvvm.ComponentModel;
using TravellersTavern.Models.Blocks;
using TravellersTavern.Services;
using TravellersTavern.ViewModels;

namespace TravellersTavern.ViewModels;

public partial class CoursesViewModel : BaseViewModel
{
    private readonly IContentService _content;

    public CoursesViewModel(IContentService content) => _content = content;

    [ObservableProperty] private string title = "";
    [ObservableProperty] private string introText = "";
    [ObservableProperty] private string calendarNote = "";

    public IReadOnlyList<CourseOptionBlock> Options { get; private set; } = Array.Empty<CourseOptionBlock>();

    public void Load()
    {
        var page = _content.Courses;
        Title = page.Title;
        IntroText = page.IntroText;
        CalendarNote = page.CalendarNote;
        Options = page.Options;
        OnPropertyChanged(nameof(Options));
    }
}
