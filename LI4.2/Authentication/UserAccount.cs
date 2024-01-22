namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class UserAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int MetodoPagamento { get; set; }
        public int DetalhesEntrega { get; set; }

        public UserAccount(string username, string password, string email, string role)
        {
            UserName = username;
            Password = password;
            Email = email;
            Role = role;
            MetodoPagamento = 0;
            DetalhesEntrega = 0;
        }

        public bool HasMetodoPagamento()
        {
            if (MetodoPagamento > 0)
            {
                return true;
            }
            return false;
        }

        public bool HasDetalhesEntrega()
        {
            if (DetalhesEntrega > 0)
            {
                return true;
            }
            return false;
        }
    }
}
