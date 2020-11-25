namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural
{
    public class FileSystemClient
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] numbers = "0123456789".ToCharArray();

        Folder root;
        private void InitializeFileStructure() {
            root = new Folder("root");
            foreach(var character in alpha) {
                var charFolder = new Folder(character.ToString());
                root.Add(charFolder);
            }

            foreach(var character in numbers) {
                var charFolder = new Folder(character.ToString());
                root.Add(charFolder);
            }
        }

        public void ShowStructure() {
            if (root == null) {
                InitializeFileStructure();
            }
            root.DisplayContents(1);
        }
    }
}