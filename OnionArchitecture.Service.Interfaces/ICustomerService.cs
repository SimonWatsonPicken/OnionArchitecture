using System.Collections.Generic;
using OnionArchitecture.Domain;

namespace OnionArchitecture.Service.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Person> GetAllCustomers();

        string GetMessage();
    }
}