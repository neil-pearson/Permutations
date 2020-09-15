namespace Permutations
{
    public static class StringUtils
    {
        public static void Swap(ref char firstChar, ref char secondChar)
        {
            if (firstChar == secondChar) return;

            var temp = firstChar;
            firstChar = secondChar;
            secondChar = temp;
        }

        public static string getString(char[] chars)
        {
            return new string(chars);
        }

    }
}
