namespace Microsoft.Workshop.Net.OOPFundamentals.OOP___Clean_Code.Naming
{
    public class Indexer
    {
        private string m_member;

        // Choose descriptive and unambiguous names.
        private int s;

        // Make meaningful distinction.
        private int index1, index2;

        // Use pronounceable names.
        private int strPtr;

        // Use searchable names.
        private int brkCompat233;

        public Indexer(int type)
        {
            // Replace magic numbers with named constants or enums.
            if (type == 10046 || type == 2002)
            {
                // Do Something
            }
        }
        // Avoid encodings. Don't append prefixes or type information.
    }
}