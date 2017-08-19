namespace Shipwreck.OpenGraph
{
    internal static class StringHelper
    {
        public static bool MachesPath(this string property, string path)
            => property?.Length > path?.Length && property.StartsWith(path) && property[path.Length] == ':';

        public static bool StartsWithChildPath(this string property, string path, string path2, out bool isMatch)
        {
            var pathLength = path.Length + 1 + path2.Length;
            if (property?.Length < pathLength)
            {
                isMatch = false;
                return false;
            }

            for (int i = 0; i < path2.Length; i++)
            {
                if (property[path.Length + 1 + i] != path2[i])
                {
                    isMatch = false;
                    return false;
                }
            }

            if (property.Length == pathLength)
            {
                isMatch = true;
                return true;
            }
            else
            {
                isMatch = false;
                return property[pathLength] == ':';
            }
        }

        public static bool MachesChildPath(this string property, string path, string path2)
            => property?.Length == path?.Length + 1 + path2.Length && property.EndsWith(path2);
    }
}