using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface DomainReport
    {
        public void CreateTicket(TravelTicket report);
        public bool UpdateTicket(TravelTicket report);
        public bool DeleteTicket(int id);
        public TravelTicket GetTicket(int id);
        public IEnumerable<TravelTicket> GetAllTickets();
    }
}