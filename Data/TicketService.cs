﻿using System;
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
            return new List<Models.ClientMessage>(_ctx.ClientMessages);
        }

        public void AddTicket(Models.ClientMessage ticket)
        {
            _ctx.ClientMessages.Add(ticket);
            _ctx.SaveChanges();
        }

        public void RemoveTicket(Models.ClientMessage ticket)
        {
            _ctx.ClientMessages.Remove(ticket);
            _ctx.SaveChanges();
        }
    }
}
