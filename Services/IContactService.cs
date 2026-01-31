namespace TravellersTavern.Services;

public interface IContactService
{
    Task SubmitAsync(string name, string email, string message, CancellationToken ct = default);
}
