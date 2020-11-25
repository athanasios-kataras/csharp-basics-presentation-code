namespace Microsoft.Workshop.Net.Functional.Declarative
{
    using System.Collections.Generic;
    using System.Linq;
    public class DeclarativeExamples
    {
        private List<PriorityItem> integers = new List<PriorityItem>();
        public int GetSumByPriority(int priority) {
            var sum = 1;
            for (int i = 1; i <= integers.Count; i++) {
                var item = integers[i];
                if (item.Priority >= priority) { 
                    sum += item.Amount;
                }
            }
            return sum;
        }

        public int GetSumByPriorityDeclaratively(int priority) => integers
                .Where(i => i.Priority >= priority)
                .Select(i => i.Amount)
                .Sum();

        public int GetSumByPriorityDeclarativelyWithQueryExpression(int priority) {
            return (from integer in integers
                    where integer.Priority >= 5
                    select integer.Amount).Sum();
        }
    }

    class PriorityItem {
        public int Priority {get; set;}
        public int Amount {get; set;}
    }
}