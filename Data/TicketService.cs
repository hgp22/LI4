using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UpShift.Models;

namespace UpShift.Data
{
    public class TicketService
    {
        private List<Models.ClientMessage> _tickets;

        public TicketService()
        {
            _tickets = new List<Models.ClientMessage>
            {
                new Models.ClientMessage(1, "pedro", "pedro@gmail.com", "111111111", "Tenho um carro para vos vender bros", DateTime.Now),
                new Models.ClientMessage(2, "guita pimpolho", "guita@gmail.com", "222222222", "ai o mano", DateTime.Now),
            };
        }

        public List<Models.ClientMessage> GetAll()
        {
            foreach (var t in _tickets)
            {
                Console.WriteLine($"Ticket {t.Id}");
            }
            return new List<Models.ClientMessage>(_tickets);
        }

        public void AddTicket(Models.ClientMessage ticket)
        {
            _tickets.Add(ticket);
            Console.WriteLine("Ticket added successfully");
            foreach (var t in _tickets)
            {
                Console.WriteLine($"Ticket {t.Id}");
            }

        }

        public void RemoveTicket(Models.ClientMessage ticket)
        {
            _tickets.Remove(ticket);
        }
    }
}
