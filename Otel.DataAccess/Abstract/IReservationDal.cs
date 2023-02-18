using Otel.Core.DataAccess;
using Otel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.DataAccess.Abstract
{
    public interface IReservationDal : IEntityRepository<Reservation>
    {

    }
}
