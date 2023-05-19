using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Entities
{
    public class TravelTicket : Entity
    {
        public ICollection from { get; set; }

        public ICollection to { get; set; }

        public Date date { get; set; }

    }
}