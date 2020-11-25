using System;
using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural
{
    public class Folder : FileSystemItem
    {
        protected List<FileSystemItem> children = new List<FileSystemItem>();
        public Folder(string name) : base(name)
        {
        }

        public override void Add(FileSystemItem c)
        {
            this.children.Add(c);
        }

        public override void DisplayContents(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);
            foreach(var child in this.children) {
                child.DisplayContents(depth + 2);
            }
        }

        public override void Remove(Guid id)
        {
            if(this.Id == id) {
                foreach(var child in this.children) {
                    child.Remove(child.Id);
                }
                // Remove myself
            } else {
                foreach(var child in this.children) {
                    child.Remove(id);
                }
            }
        }
    }
}