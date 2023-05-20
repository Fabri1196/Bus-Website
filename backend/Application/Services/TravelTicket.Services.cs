using Domain.Entities;
using Domain.Services;

namespace Application.Services
{
    public class ReportService : DomainReport
    {
        private DomainRepository<TravelTicket> _repository;

        public ReportService(DomainRepository<TravelTicket> repository)
        {
            _repository = repository;
        }
        public void CreateTicket(TravelTicket travelTicket)
        {
            _repository.Insert(travelTicket);
        }

        public bool DeleteTicket(int id) => _repository.Delete(id);

        public IEnumerable<TravelTicket> GetAllTickets() => _repository.GetAll();

        public TravelTicket GetTicket(int Id) => _repository.GetById(Id);

        public bool UpdateTicket(TravelTicket travelTicket)
        {
           return  _repository.Upsert(travelTicket);
        }
    }
}
