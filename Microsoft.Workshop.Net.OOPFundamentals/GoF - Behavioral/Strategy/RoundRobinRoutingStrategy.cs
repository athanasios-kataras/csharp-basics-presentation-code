using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Strategy
{
    public class RoundRobinRoutingStrategy : IServerRoutingStrategy
    {
        private int currentIndex = 0;
        public Server GetEligibleServer(List<Server> availableServers)
        {
            return availableServers[currentIndex++];
        }
    }
}