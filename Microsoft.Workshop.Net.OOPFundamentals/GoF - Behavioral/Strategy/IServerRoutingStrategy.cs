using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Strategy
{
    public interface IServerRoutingStrategy
    {
        Server GetEligibleServer(List<Server> availableServers);
    }
}