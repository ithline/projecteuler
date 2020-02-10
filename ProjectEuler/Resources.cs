using System.IO;

namespace ProjectEuler
{
    internal static class Resources
    {
        public static Stream Open(string name) => typeof(Resources).Assembly.GetManifestResourceStream($"ProjectEuler.Resources.{name}");
    }
}
