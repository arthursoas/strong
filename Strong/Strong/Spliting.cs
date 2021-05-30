using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Strong
{
    public static class Spliting
    {
        public static IEnumerable<string> SplitCamelCase(this string source)
        {
            var matches = Regex.Matches(source, @"[A-Z][a-z]*|[a-z]+|\d+");
            foreach (Match match in matches)
            {
                yield return match.Value.ToLowerInvariant();
            }
        }
    }
}
