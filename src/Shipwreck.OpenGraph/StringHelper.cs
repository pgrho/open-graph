namespace Shipwreck.OpenGraph
{
    internal static class StringHelper
    {
        public static bool MachesPath(this string property, string path)
            => property?.Length > path?.Length && property.StartsWith(path) && property[path.Length] == ':';

        public static bool StartsWithChildPath(this string property, string path, string path2)
        {
            if (property?.Length < path?.Length + 1 + path2.Length)
            {
                return false;
            }

            for (int i = 0; i < path2.Length; i++)
            {
                if (property[path.Length + 1 + i] != path2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool MachesChildPath(this string property, string path, string path2)
            => property?.Length == path?.Length + 1 + path2.Length && property.EndsWith(path2);
    }
}