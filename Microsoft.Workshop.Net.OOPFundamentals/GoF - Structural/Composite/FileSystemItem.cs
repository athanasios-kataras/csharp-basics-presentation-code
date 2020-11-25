using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural
{
    public abstract class FileSystemItem
    {
        public string Name { get; }
        public Guid Id { get; }

        public FileSystemItem(string name)
        {
            this.Name = name;
            this.Id = new Guid();
        }

        public abstract void DisplayContents(int depth);
        public abstract void Add(FileSystemItem c);
        public abstract void Remove(Guid c);

    }
}