using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{

    public class SpecialComparer : IComparer<string>
    {

        public int Compare(string value1, string value2)
        {
            CharComparer myCharComparer = new CharComparer();
            int len = value1.Length;
            char[] charArr1 = value1.ToCharArray();
            char[] charArr2 = value2.ToCharArray();

            for (int i = 0; i < len; i++)
            {
                int compareResult = myCharComparer.Compare(charArr1[i], charArr2[i]);
                if (compareResult != 0) return compareResult;
            }
            return 0;
        }

    }

    public class CharComparer : IComparer<char>
    {

        public int Compare(char char1, char char2)
        {
            if (char.IsDigit(char1))
            {
                if (char.IsDigit(char2)) return (char1.CompareTo(char2));
                else return -1;
            }
            else if (char.IsUpper(char1))
            {
                if (char.IsDigit(char2)) return 1;
                else if (char.IsUpper(char2)) return (char1.CompareTo(char2));
                else return -1;
            }
            else if (char.IsLower(char1))
            {
                if (char.IsDigit(char2) || char.IsUpper(char2)) return 1;
                else if (char.IsLower(char2)) return (char1.CompareTo(char2));
                else return -1;
            }
            else
            {
                if (char.IsDigit(char2) || char.IsUpper(char2) || char.IsLower(char2)) return 1;
                else return (char1.CompareTo(char2));
            }
        }

    }

}
