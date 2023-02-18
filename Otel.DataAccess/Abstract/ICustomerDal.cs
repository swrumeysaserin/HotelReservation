using Otel.Core.DataAccess;
using Otel.Entites.Concrete;

namespace Otel.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
