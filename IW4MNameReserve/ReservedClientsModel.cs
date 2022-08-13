using SharedLibraryCore.Interfaces;

namespace IW4MNameReserve;

public class ReservedClientsModel
{
    public string Guid { get; set; }
    public string Name { get; set; }
}

public class ReservedClientsConfiguration : IBaseConfiguration
{
    public List<ReservedClientsModel> ReservedClients { get; } = new()
    {
        new ReservedClientsModel
        {
            Guid = "0001110001110001",
            Name = "ExampleNameOne"
        },
        new ReservedClientsModel
        {
            Guid = "0001110001110002",
            Name = "ExampleNameTwo"
        }
    };

    public string KickMessage { get; } = "Name reserved. Change your name";

    public string Name() => "ReservedClients";

    public IBaseConfiguration Generate() => new ReservedClientsConfiguration();
}