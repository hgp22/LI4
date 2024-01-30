using System.ComponentModel.DataAnnotations;

namespace UpShift.Models
{
    public class ClientMessage
    {
        [Key]
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPhoneNumber { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public ClientMessage(int id, string nome, string email, string telefone, string mensagem, DateTime data)
        {
            Id = id;
            ClientName = nome;
            ClientEmail = email;
            ClientPhoneNumber = telefone;
            Message = mensagem;
            Timestamp = data;
        }

        public ClientMessage()
        {

        }
    }
}
