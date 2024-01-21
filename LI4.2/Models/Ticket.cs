namespace BlazorServerAuthenticationAndAuthorization.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Mensagem { get; set; }

        public Ticket(int id, string nome, string email, string telefone, string mensagem)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Mensagem = mensagem;
        }

        public Ticket()
        {

        }
    }
}
