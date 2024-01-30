using UpShift.Authentication;
using UpShift.Controllers;
using UpShift.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Web;
using Hangfire.Dashboard;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json");

// Add services to the container.
builder.Services.AddAuthenticationCore();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddHttpClient();

builder.Services.AddScoped<IUserController, UserController>();
builder.Services.AddScoped<ILeilaoController, LeilaoController>();
builder.Services.AddScoped<ILicitacaoController, LicitacaoController>();
builder.Services.AddScoped<IVeiculoController, VeiculoController>();
builder.Services.AddScoped<IMarcaController, MarcaController>();
builder.Services.AddScoped<IModeloController, ModeloController>();

builder.Services.AddScoped<TicketService>();
builder.Services.AddScoped<LeilaoService>();
builder.Services.AddScoped<LicitacaoService>();
builder.Services.AddScoped<UtilizadorService>();
builder.Services.AddScoped<ModeloService>();
builder.Services.AddScoped<VeiculoService>();
builder.Services.AddScoped<MarcaService>();
builder.Services.AddScoped<DataBaseContext>();

var configuration = builder.Configuration;

builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

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
