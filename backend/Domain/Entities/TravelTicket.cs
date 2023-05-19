using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    /// <summary>
    /// Individual reports aggregated into a recurring location (ReportAggregate).
    /// </summary>

    public class TravelTicket : entity
    {
        public ICollection from { get; set; }

        public ICollection from { get; set; }

        public Date date { get; set; }

    }
    /// <summary>
    /// To be used by the de-serializer
    /// </summary>
    public ReportAggregate() { }
}