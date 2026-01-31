namespace TravellersTavern.Services;

public class ContactService : IContactService
{
    private readonly ILogger<ContactService> _logger;

    public ContactService(ILogger<ContactService> logger) => _logger = logger;

    public Task SubmitAsync(string name, string email, string message, CancellationToken ct = default)
    {
        // Later: e-mail sturen, opslaan in database, webhook, etc.
        _logger.LogInformation("Contact submitted by {Name} ({Email}). Message length: {Len}",
            name, email, message?.Length ?? 0);

        return Task.CompletedTask;
    }
}
