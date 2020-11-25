namespace Microsoft.Workshop.Net.Functional.Declarative
{
    using System.Text;
    public class PureFunctions
    {
        public static StringBuilder Concat(StringBuilder sb, string append)
        {
            return sb.Append('-' + append);
        }

        public static StringBuilder ConcatPure(StringBuilder sb, string append)
        {
            return new StringBuilder(sb.ToString()).Append('-' + append);
        }

        public static string ConcatPure2(StringBuilder sb, string append) {
            var str = sb.ToString();
            return (str + "-" + append);
        }
    }
}