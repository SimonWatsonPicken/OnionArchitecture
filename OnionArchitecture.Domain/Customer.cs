using System.Collections.Generic;
using OnionArchitecture.Domain.Interfaces;

namespace OnionArchitecture.Domain
{
    public sealed class Customer : Person
    {
        public IEnumerable<IAddress> Addresses { get; set; }
    }
}
