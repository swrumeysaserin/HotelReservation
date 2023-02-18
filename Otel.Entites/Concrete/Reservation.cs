using Otel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.Entites.Concrete
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int OtelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate{ get; set; }
        public DateTime  CreateDate { get; set; }
        public decimal  Price { get; set; }
        
    }
}
