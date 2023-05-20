using Domain;
using Domain.Entities;
using Domain.Services;
using LiteDB;

namespace Infrastructure.Database
{
    public class TravelTicketRepository : DomainRepository<TravelTicket>
    {
        private LiteDatabase _database;
        private ILiteCollection<TravelTicket> _collection;

        public TravelTicketRepository(LiteDatabase database)
        {
            _database = database;
            _collection = _database.GetCollection<TravelTicket>("Tickets");
        }
        public int Insert(TravelTicket entity) => _collection.Insert(entity);

        public bool Delete(int id) => _collection.Delete(id);

        public bool DeleteAll() => _collection.DeleteAll() > 0;

        public IEnumerable<TravelTicket> GetAll() => _collection.FindAll();

        public TravelTicket GetById(int id) => _collection.FindById(id);

        public bool Update(TravelTicket entity) => _collection.Update(entity);

        public bool Upsert(TravelTicket entity) => _collection.Upsert(entity);

        public void Dispose() { }
    }

}
