using Otel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.Business.Abstract
{
    public interface IOtelService
    {
        void Add(OtelModel otelModel);
        void Update(OtelModel otelModel);
        List<OtelModel> List();
        List<OtelModel> List(string name);
        OtelModel Get(string name);
        OtelModel Get(int Id);
    }
}
