using System.Text;

namespace Strong
{
    public static class Misc
    {
        /// <summary>
        /// Remove spaces in the begining, ending and
        /// double (or more) spaces between words in a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SuperTrim(this string str)
        {
            var stringBuilder = new StringBuilder();

            str = str.Trim();
            var chars = str.ToCharArray();

            for (var index = 0; index < chars.Length; index++)
            {
                if (chars[index] == ' ' && chars[index + 1] == ' ') continue;
                stringBuilder.Append(chars[index]);
            }

            return stringBuilder.ToString();
        }

        public static string RemoveFirstOcurrence(this string str, char remove)
        {
            if (remove == default) return str;

            return str.RemoveFirstOcurrence(remove.ToString());
        }

        public static string RemoveFirstOcurrence(this string str, string remove)
        {
            if (remove == default) return str;

            var removingIndex = str.IndexOf(remove);
            return removingIndex == -1 ? str : str.Remove(removingIndex, remove.Length);
        }

        public static bool IsEmpty(this string str)
        {
            return str == null || str.SuperTrim() == "";
        }
    }
}
