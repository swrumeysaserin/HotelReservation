using Otel.Business.Abstract;
using Otel.DataAccess.Abstract;
using Otel.Entites.Concrete;
using System.Collections.Generic;

namespace Otel.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer Customer)
        {
            _customerDal.Add(Customer);
        }

        public Customer Get(string name)
        {
            return _customerDal.Get(x => x.Name == name);
        }

        public Customer Get(int Id)
        {
            return _customerDal.Get(x => x.Id == Id);
        }

        public List<Customer> List()
        {
            return _customerDal.List();
        }
        public List<Customer> List(string name)
        {
            return _customerDal.List(x => x.Name.ToUpper().Contains(name.ToUpper()));
        }
        public void Update(Customer Customer)
        {
            _customerDal.Update(Customer);
        }
    }
}
