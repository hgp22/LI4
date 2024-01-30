using System.ComponentModel.DataAnnotations;

namespace UpShift.Models
{
    public class Utilizador {
        [Key]
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Nif { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool IsAdmin { get; set; }
        public int MetodoPagamento { get; set; }
        public int DetalhesEntrega { get; set; }

        public Utilizador(string username, string email, string password, int nif, string nome, DateTime dataNascimento, bool isAdmin)
        {
            Username = username;
            Email = email;
            Password = password;
            Nif = nif;
            Nome = nome;
            DataNascimento = dataNascimento;
            IsAdmin = isAdmin;
            MetodoPagamento = 0;
            DetalhesEntrega = 0;
        }

        public Utilizador(string username, string email, string password, int nif, string nome, DateTime dataNascimento, bool isAdmin, int metodoPagamento, int detalhesEntrega)
        {
            Username = username;
            Email = email;
            Password = password;
            Nif = nif;
            Nome = nome;
            DataNascimento = dataNascimento;
            IsAdmin = isAdmin;
            MetodoPagamento = metodoPagamento;
            DetalhesEntrega = detalhesEntrega;
        }


        public Utilizador(string username, string password, string email, bool role)
        {
            Username = username;
            Password = password;
            Email = email;
            IsAdmin = role;
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
