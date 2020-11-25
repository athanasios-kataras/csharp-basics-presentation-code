namespace Microsoft.Workshop.Net.Functional.Declarative
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class FuncDelegates
    {
        List<int> integers = new List<int>() { 1, 2, 1, 3, 4};

        public List<int> FindAll(Func<int, bool> condition) {
            List<int> newIntList = new List<int>();
            foreach(int item in integers){
                if (condition(item)) {
                    newIntList.Add(item);
                }
            }
            return newIntList;
        }

        public void DoWork() {
            Console.WriteLine("Contains Value:" + FindAll(x => x == 1).Aggregate("", (current, next) => current + ", " + next));
            Console.WriteLine("Greater than:" + FindAll(x => x > 1).Aggregate("", (current, next) => current + ", " + next));
        }
    }

    public class PredicateDelegates
    {
        List<int> integers = new List<int>() { 1, 2, 1, 3, 4};

        public List<int> FindAll(Predicate<int> condition) {
            List<int> newIntList = new List<int>();
            foreach(int item in integers){
                if (condition(item)) {
                    newIntList.Add(item);
                }
            }
            return newIntList;
        }

        public void DoWork() {
            Console.WriteLine("Contains Value:" + FindAll(x => x == 1)
                .Aggregate("", (current, next) => current + ", " + next));
            Console.WriteLine("Greater than:" + FindAll(x => x > 1)
            .Aggregate("", (current, next) => current + ", " + next));
        }
    }

    public class ActionDelegates
    {
        public delegate void Print(int val);
        static void PrintDelegate(string[] args)
        {
            Print prnt = ConsolePrint;
            prnt(10);
        }
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        public void PrintAction(int i)
        {
            Action<int> printActionDel = ConsolePrint;
            ConsolePrint(i);
        }
    }
}