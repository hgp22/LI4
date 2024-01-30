using Microsoft.AspNetCore.Components;
using UpShift.Authentication;
using UpShift.Models;

namespace UpShift.Controllers
{
    public class AuthenticationController : ComponentBase
    {

        UserController userController = new UserController();

        [Inject]
        protected CustomAuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected UserController UserAccountService { get; set; }

        public async Task LoginAsync(string username, string password)
        {
            Utilizador utilizador = userController.GetByUsername(username);
            if (utilizador != null && password == utilizador.Password)
            {
                var userSession = new UserSession
                {
                    UserName = utilizador.Username,
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

