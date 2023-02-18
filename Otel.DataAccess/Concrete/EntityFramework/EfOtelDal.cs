using Otel.Core.DataAccess.EntityFramework;
using Otel.DataAccess.Abstract;
using Otel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.DataAccess.Concrete.EntityFramework
{
    public class EfOtelDal : EfEntityRepositoryBase<OtelModel, OtelContext>, IOtelDal
    {
    }
}
