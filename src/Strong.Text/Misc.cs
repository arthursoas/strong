using System.Text;

namespace Strong.Text
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

        /// <summary>
        /// Remove the first occurence of a character.
        /// If the character does not exists, return the string itself
        /// </summary>
        /// <param name="str"></param>
        /// <param name="remove">character to be removed</param>
        /// <returns>String without the first occurence of character</returns>
        public static string RemoveFirstOcurrence(this string str, char remove)
        {
            if (remove == default) return str;

            return str.RemoveFirstOcurrence(remove.ToString());
        }

        /// <summary>
        /// Remove the first occurence of a sub string.
        /// If the sub string does not exists, return the string itself
        /// </summary>
        /// <param name="str"></param>
        /// <param name="remove">sub string to be removed</param>
        /// <returns>String without the first occurence of sub string</returns>
        public static string RemoveFirstOcurrence(this string str, string remove)
        {
            if (remove == default) return str;

            var removingIndex = str.IndexOf(remove);
            return removingIndex == -1 ? str : str.Remove(removingIndex, remove.Length);
        }
    }
}
