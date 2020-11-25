using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural
{
    public class RootFolder : Folder
    {
        public RootFolder(string name) : base(name)
        {
        }

        public override void Remove(Guid id) {
            if (this.Id == id) {
                throw new Exception("Can't delete root folder");
            }
            base.Remove(id);
        }
    }
}