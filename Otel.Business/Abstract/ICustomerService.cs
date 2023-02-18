using Otel.Entites.Concrete;
using System.Collections.Generic;


namespace Otel.Business.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer Customer);
        void Update(Customer Customer);
        List<Customer> List();
        List<Customer> List(string name);
        Customer Get(string name);
        Customer Get(int Id);
    }
}
