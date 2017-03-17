using System.Globalization;
using OnionArchitecture.Domain.Interfaces;

namespace OnionArchitecture.Domain
{
    public sealed class Address : IAddress
    {
        #region Fields and constants

        private const string CultureName = "en-GB";

        #endregion

        #region Constructors

        public Address()
        {
            var region = new RegionInfo(CultureName);
            RegionName = region.TwoLetterISORegionName;
        }

        #endregion Constructors

        #region Properties

        public int Id { get; set; }

        public string OrganisationName { get; set; }

        public string BuildingName { get; set; }

        public string Street { get; set; }

        public string Locality { get; set; }

        public string Town { get; set; }

        public string Postcode { get; set; }

        public string RegionName { get; }

        #endregion Properties
    }
}