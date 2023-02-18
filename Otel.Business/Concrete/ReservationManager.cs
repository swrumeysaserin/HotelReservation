using Otel.Business.Abstract;
using Otel.DataAccess.Abstract;
using Otel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }
        public void Add(Reservation model)
        {
            _reservationDal.Add(model);
        }

        public Reservation Get(int Id)
        {
            return _reservationDal.Get(x => x.Id == Id);
        }

        public List<Reservation> List()
        {
            return _reservationDal.List();
        }



        public void Update(Reservation model)
        {
            _reservationDal.Update(model);
        }
    }
}
