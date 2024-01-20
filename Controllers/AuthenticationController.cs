using Microsoft.AspNetCore.Components;
using UpShift.Authentication;
using UpShift.Models;

namespace UpShift.Controllers
{
    public class AuthenticationController : ComponentBase
    {
        [Inject]
        protected CustomAuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected UserAccountService UserAccountService { get; set; }

        public async Task LoginAsync(string username, string password)
        {
            Utilizador utilizador = UserAccountService.GetByUsername(username);
            if (utilizador != null && password == utilizador.Password)
            {
                var userSession = new UserSession
                {
                    Username = utilizador.Username,
                    Role = utilizador.Role
                };

                await AuthenticationStateProvider.UpdateAuthenticationState(userSession);

                NavigationManager.NavigateTo("/");
            }                
            else
            {
                NavigationManager.NavigateTo("/login");
            }
        }

        public async Task LogoutAsync()
        {
            await AuthenticationStateProvider.UpdateAuthenticationState(null);

            NavigationManager.NavigateTo("/login");
        }
    }
}

