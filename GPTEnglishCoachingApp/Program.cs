using GPTEnglishCoachingApp.Components;
using MudBlazor.Services;
using Azure.AI.OpenAI;
using Azure.Identity;
using Microsoft.Extensions.Azure;
using GPTEnglishCoachingApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.Configure<AppConfig>(builder.Configuration.GetSection(AppConfig.SectionName));

builder.Services.AddAzureClients(clientBuilder =>
{
    // Register clients for each service
    clientBuilder.AddOpenAIClient(new Uri(builder.Configuration.GetSection(AppConfig.SectionName).GetValue<string>("OpenAIEndpoint")??throw new ArgumentNullException("OpenAIEndpoint is not set")));
    clientBuilder.UseCredential(new DefaultAzureCredential());
});

builder.Services.AddMudServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
