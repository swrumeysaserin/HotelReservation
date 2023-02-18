using Otel.Business.Abstract;
using Otel.DataAccess.Abstract;
using Otel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.Business.Concrete
{
    public class OtelManager : IOtelService
    {
        private readonly IOtelDal _otelDal;
        public OtelManager(IOtelDal otelDal)
        {
            _otelDal = otelDal;
        }
        public void Add(OtelModel otelModel)
        {
            _otelDal.Add(otelModel);
        }
        public void Update(OtelModel otelModel)//-----------
        {
            _otelDal.Update(otelModel);
        }
        public OtelModel Get(string name)
        {
            return _otelDal.Get(x => x.Name == name);
        }

        public OtelModel Get(int Id)
        {
            return _otelDal.Get(x => x.Id == Id);
        }

        public List<OtelModel> List()
        {
            return _otelDal.List();
        }

        public List<OtelModel> List(string name)
        {
           return _otelDal.List(x => x.Name.ToUpper() == name.ToUpper());
        }
    }
}
