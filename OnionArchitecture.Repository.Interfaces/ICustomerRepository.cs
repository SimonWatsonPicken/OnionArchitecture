using System.Collections.Generic;
using OnionArchitecture.Domain;

namespace OnionArchitecture.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Person> All { get; set; }
    }
}