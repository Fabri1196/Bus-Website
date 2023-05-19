using Domain;
using Domain.Entities;
using Domain.Services;
using LiteDB;

namespace Infrastructure.Repository
{
    /// <summary>
    /// Handles database operations using LiteDB (NoSQL)
    /// </summary>
    public class TravelTicketRepository : IRepository, IDisposable
    {
        private TravelTicketContext context;

        public travelTicketRepository(TravelTicketContext context)
        {
            this.context = context;
        }

        public IEnumerable<TravelTicket> GetAll()
        {
            return context.TravelTicket.FindAll();
        }

        public TravelTicket GetStudentByID(int id)
        {
            return context.TravelTicket.Find(id);
        }

        public void InsertTravelTicket(TravelTicket travelTicket)
        {
            context.TravelTicket.Add(travelTicket);
        }

        public void DeleteTravelTicket(int travelTicketID)
        {
            TravelTicket travelTicket = context.TravelTicket.Find(travelTicketID);
            context.TravelTicket.Remove(travelTicket);
        }

        public void UpdateTravelTicket(travelTicket travelTicket)
        {
            context.Entry(travelTicket).State = context.Update(travelTicket);
        }
    }

}
