using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TravellersTavern.Services;
using TravellersTavern.ViewModels;

namespace TravellersTavern.ViewModels;

public partial class PrivateSessionViewModel : BaseViewModel
{
    private readonly IContentService _content;
    private readonly IContactService _contact;

    public PrivateSessionViewModel(IContentService content, IContactService contact)
    {
        _content = content;
        _contact = contact;
    }

    [ObservableProperty] private string title = "";
    [ObservableProperty] private string introText = "";

    [ObservableProperty] private ContactForm form = new();

    [ObservableProperty] private bool submitted;
    [ObservableProperty] private string? successMessage;

    public void Load()
    {
        var page = _content.PrivateSession;
        Title = page.Title;
        IntroText = page.IntroText;
    }

    [RelayCommand]
    private async Task SubmitAsync()
    {
        await RunBusyAsync(async () =>
        {
            // Validatie
            var ctx = new ValidationContext(Form);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(Form, ctx, results, true))
            {
                ErrorMessage = string.Join(" ", results.Select(r => r.ErrorMessage).Where(x => !string.IsNullOrWhiteSpace(x)));
                return;
            }

            await _contact.SubmitAsync(Form.Name, Form.Email, Form.Message);
            Submitted = true;
            SuccessMessage = "Bedankt. Je bericht is verstuurd.";
            Form = new ContactForm();
        });
    }

    public class ContactForm
    {
        [Required, StringLength(80)]
        public string Name { get; set; } = "";

        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required, StringLength(2000)]
        public string Message { get; set; } = "";
    }
}
