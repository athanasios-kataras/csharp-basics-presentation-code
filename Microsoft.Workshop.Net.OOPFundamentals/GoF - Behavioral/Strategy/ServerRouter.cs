using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Strategy
{
    public class MachineSelector
    {
        private List<Server> availableServers = new List<Server>();
        private IServerRoutingStrategy stragety;

        public MachineSelector(IServerRoutingStrategy stragety) {
            this.stragety = stragety;
        }

        public void Add(Server server) {
            this.availableServers.Add(server);
        }

        public void Add(List<Server> servers) {
            this.availableServers.AddRange(servers);
        }

        public Server GetEligibleServer() {
            this.availableServers.ForEach(_ => _.Refresh());
            return this.stragety.GetEligibleServer(availableServers);
        }
    }
}