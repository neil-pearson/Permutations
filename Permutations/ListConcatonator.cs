using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    public class ListConcatonator : IListConcatonator
    {
        const string delimeter = ",";
        public ListConcatonator()
        {

        }

        public string ConcatList(IEnumerable<string> list)
        {
            if (list == null) return "";
            if (list.Count() == 0) return "";
            StringBuilder sb = new StringBuilder();
            foreach (string s in list)
            {
                sb.Append(s);
                sb.Append(delimeter);
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

    }

    public interface IListConcatonator
    {
        string ConcatList(IEnumerable<string> list);
    }
}
