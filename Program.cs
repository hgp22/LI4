using UpShift.Authentication;
using UpShift.Controllers;
using UpShift.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Web;
using Hangfire;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Hangfire.Dashboard;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json");

// Add services to the container.
builder.Services.AddAuthenticationCore();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddHttpClient();

builder.Services.AddHostedService<LeilaoService>();

builder.Services.AddTransient<IUserController, UserController>();
builder.Services.AddTransient<ILeilaoController, LeilaoController>();
builder.Services.AddTransient<ILicitacaoController, LicitacaoController>();
builder.Services.AddTransient<IVeiculoController, VeiculoController>();
builder.Services.AddTransient<IMarcaController, MarcaController>();
builder.Services.AddTransient<IModeloController, ModeloController>();

builder.Services.AddSingleton<TicketService>();
builder.Services.AddSingleton<LeilaoService>();
builder.Services.AddSingleton<LicitacaoService>();
builder.Services.AddSingleton<UtilizadorService>();
builder.Services.AddSingleton<ModeloService>();
builder.Services.AddSingleton<VeiculoService>();
builder.Services.AddSingleton<MarcaService>();
builder.Services.AddScoped<DataBaseContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

public class HangfireAuthorizationFilter : IDashboardAuthorizationFilter
{
    public bool Authorize(DashboardContext context)
    {
        // Implemente sua lógica de autorização aqui, por exemplo, verifique se o usuário está autenticado e tem permissão
        return true;
    }
}
