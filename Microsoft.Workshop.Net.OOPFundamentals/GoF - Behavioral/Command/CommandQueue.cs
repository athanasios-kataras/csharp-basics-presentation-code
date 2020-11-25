using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command.Commands;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Command
{
    public class CommandQueue
    {
        private static List<ITransactionCommand> commands = new List<ITransactionCommand>();
        private static int index = 0;
        private static readonly object lockObject = new object();

        public bool Add(ITransactionCommand command) {
            lock(lockObject) {
                commands.Add(command);
            }
            return true;
        }

        public ITransactionCommand GetCurrent() {
            lock(lockObject) {
                return commands[index++];
            }
        }
    }
}