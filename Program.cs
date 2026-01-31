using TravellersTavern.Services;
using TravellersTavern.ViewModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<IContentService, ContentService>();
builder.Services.AddSingleton<IContactService, ContactService>();

builder.Services.AddScoped<HomeViewModel>();
builder.Services.AddScoped<PublicGamesViewModel>();
builder.Services.AddScoped<CoursesViewModel>();
builder.Services.AddScoped<PrivateSessionViewModel>();
builder.Services.AddScoped<SimpleTextPageViewModel>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<TravellersTavern.Components.App>()
   .AddInteractiveServerRenderMode();

app.Run();
