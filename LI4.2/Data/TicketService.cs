using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorServerAuthenticationAndAuthorization.Models;

namespace BlazorServerAuthenticationAndAuthorization.Data
{
    public class TicketService
    {
        private List<Ticket> _tickets;

        public TicketService()
        {
            _tickets = new List<Ticket>
            {
                new Ticket(1, "pedro", "pedro@gmail.com", "111111111", "Tenho um carro para vos vender bros"),
                new Ticket(2, "guita pimpolho", "guita@gmail.com", "222222222", "ai o mano"),
            };
        }

        public List<Ticket> GetAll()
        {
            foreach (var t in _tickets)
            {
                Console.WriteLine($"Ticket {t.Id}");
            }
            return new List<Ticket>(_tickets);
        }

        public void AddTicket(Ticket ticket)
        {
            _tickets.Add(ticket);
            Console.WriteLine("Ticket added successfully");
            foreach (var t in _tickets)
            {
                Console.WriteLine($"Ticket {t.Id}");
            }

        }

        public void RemoveTicket(Ticket ticket)
        {
            _tickets.Remove(ticket);
        }
    }
}
