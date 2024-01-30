using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UpShift.Models;

namespace UpShift.Data
{
    public class TicketService
    {
        private readonly DataBaseContext _ctx;

        public TicketService(DataBaseContext ctx)
        {
            _ctx = ctx;
        }

        public List<Models.ClientMessage> GetAll()
        {
            List<Models.ClientMessage> tickets = _ctx.ClientMessages.ToList();
            foreach (var t in tickets)
            {
                Console.WriteLine($"Ticket {t.Id}");
            }
            return new List<Models.ClientMessage>(_ctx.ClientMessages);
        }

        public void AddTicket(Models.ClientMessage ticket)
        {
            _ctx.ClientMessages.Add(ticket);
            Console.WriteLine("Ticket added successfully");
            foreach (var t in _ctx.ClientMessages)
            {
                Console.WriteLine($"Ticket {t.Id}");
            }
            _ctx.SaveChanges();
        }

        public void RemoveTicket(Models.ClientMessage ticket)
        {
            _ctx.ClientMessages.Remove(ticket);
            _ctx.SaveChanges();
        }
    }
}
