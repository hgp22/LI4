namespace UpShift.Authentication
{
    public class Utilizador
    {
        public string Username {  get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Nif { get; set; }
        public int PaymentMethod { get; set; }
        public int DeliveryMethod { get; set; }
        public string Role { get; set; }

        public Utilizador(string username, string password, string email, DateTime birthdate, string nif, int paymentMethod, int deliveryMethod, string role)
        {
            Username = username;
            Password = password;
            Email = email;
            Birthdate = birthdate;
            Nif = nif;
            PaymentMethod = paymentMethod;
            DeliveryMethod = deliveryMethod;
            Role = role;
        }
    }
}
