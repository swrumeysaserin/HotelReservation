using Otel.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using Otel.Entites.Concrete;

namespace Otel.DataAccess.Abstract
{
    public interface IOtelDal : IEntityRepository<OtelModel>
    {
    }
}
