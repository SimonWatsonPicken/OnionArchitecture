using System.Collections.Generic;
using System.Linq;
using OnionArchitecture.Domain;
using OnionArchitecture.Domain.Interfaces;
using OnionArchitecture.Repository.Interfaces;

namespace OnionArchitecture.Repository.MemCached
{
    // ReSharper disable once ClassNeverInstantiated.Global
    // Class instantiated via StructureMap dependency injection.
    public sealed class CustomerRepository : ICustomerRepository
    {
        #region Fields and Constants

        private readonly List<Customer> _customers;

        #endregion Fields and Constants

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRepository"/> class.
        /// </summary>
        public CustomerRepository()
        {
            var addresses = new List<IAddress>
            {
                new Address
                {
                    Id = 1,
                    Street = "43, Quay 2000",
                    Locality = "Horseshoe Bridge",
                    Town = "Southampton",
                    Postcode = "SO17 2NP"
                },
                new Address
                {
                    Id = 2,
                    OrganisationName = "Caternet Ltd.",
                    BuildingName = "34 Warwick Court",
                    Street = "Leigh Road",
                    Town = "Eastleigh",
                    Postcode = "SO50 9DT"
                }
            };

            _customers = new List<Customer>
            {
                new Customer
                {
                    Forename = "Simon",
                    Surname = "Watson-Picken",
                    Addresses = addresses
                },
                new Customer {Forename = "Claire", Surname = "Tuckett", Addresses = addresses.Where(a => a.Id == 1)}
            };
        }

        #endregion Constructors

        #region Properties

        public IEnumerable<Person> All
        {
            get { return _customers; }

            set { throw new System.NotImplementedException(); }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}