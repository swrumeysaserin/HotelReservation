using Otel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.Entites.Concrete
{
    public class OtelModel : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OtelAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
