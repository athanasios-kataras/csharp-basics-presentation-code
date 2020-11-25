using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural
{
    public class File : FileSystemItem
    {
        public File(string name) : base(name)
        {
        }

        public override void Add(FileSystemItem c)
        {
            throw new NotImplementedException();
        }

        public override void DisplayContents(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);
        }

        public override void Remove(Guid id)
        {
            if(id == this.Id) {
                // Remove myself
            }
        }
    }
}