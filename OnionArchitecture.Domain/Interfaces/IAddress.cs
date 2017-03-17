namespace OnionArchitecture.Domain.Interfaces
{
    public interface IAddress
    {
        int Id { get; set; }

        string RegionName { get; }
    }
}