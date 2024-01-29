namespace UpShift.Models
{
    public class ClientMessage
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; }

        public ClientMessage(int id, string nome, string email, string telefone, string mensagem, DateTime data)
        {
            Id = id;
            NomeCliente = nome;
            EmailCliente = email;
            TelefoneCliente = telefone;
            Mensagem = mensagem;
            Data = data;
        }

        public ClientMessage()
        {

        }
    }
}
