using Otel.Core.DataAccess.EntityFramework;
using Otel.DataAccess.Abstract;
using Otel.Entites.Concrete;

namespace Otel.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer, OtelContext>, ICustomerDal
    {

    }
}
