using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permutations
{
    public interface IPermutationCalcer
    {
        List<string> permutations { get; set; }

        void calcPermutations(string str);
        void GetPerms(char[] list, int currPos, int endPos);
    }

    public class PermutationCalcer : IPermutationCalcer
    {

        public List<string> permutations { get; set; }
        public PermutationCalcer() 
        {
            this.permutations = new List<string>();
        }

        public void calcPermutations(string str)
        {
            this.permutations = new List<string>();

            char[] chars = str.ToCharArray();

            int n = chars.Length - 1;
            GetPerms(chars, 0, n);
        }

        public void GetPerms(char[] list, int currPos, int endPos)
        {
            if (currPos == endPos)
            {
                permutations.Add(StringUtils.getString(list));
            }
            else
                for (int i = currPos; i <= endPos; i++)
                {
                    StringUtils.Swap(ref list[currPos], ref list[i]);
                    GetPerms(list, currPos + 1, endPos);
                    StringUtils.Swap(ref list[currPos], ref list[i]);
                }
        }
    }
}
