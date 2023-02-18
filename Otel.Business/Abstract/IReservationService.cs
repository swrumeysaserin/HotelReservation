using Otel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.Business.Abstract
{
    public interface IReservationService
    {
        void Add(Reservation model);
        void Update(Reservation model);
        List<Reservation> List();
        Reservation Get(int Id);
    }
}
