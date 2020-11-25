namespace Microsoft.Workshop.Net.Functional.Declarative
{
    using System;
    using System.Collections.Generic;

    public delegate void PrintDelegate(string message);

    public class DelegateExample
    {
        public List<PrintDelegate> printDelegates = new List<PrintDelegate>();

        public PrintDelegate GetDelegate(int index)
        {
            return printDelegates[index];
        }

        public void AddDelegate(PrintDelegate del)
        {
            printDelegates.Add(del);
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class CombinedDelegates {
        private PrintDelegate printDelegate;

        public void RegisterToPrintEvent(PrintDelegate eventCallback) {
            printDelegate += eventCallback;
        }

        public void RaiseEvent(string message) {
            printDelegate(message);
        }

    }
}