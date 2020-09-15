using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{

    public interface IPermutationDisplayer
    {
        List<String> displayPermsFromFile(string file);
    }

    public class PermutationDisplayer : IPermutationDisplayer
    {

        private FileProcessor fileProcessor;
        private IPermutationCalcer permutationCalcer;
        private IComparer<string> specialComparer;
        private IListConcatonator listConcatonator;

        public PermutationDisplayer(FileProcessor pFileProcessor, IPermutationCalcer pPermutationCalcer,
            IComparer<string> pSpecialComparer, IListConcatonator pListConcatonator)
        {
            fileProcessor = pFileProcessor;
            permutationCalcer = pPermutationCalcer;
            specialComparer = pSpecialComparer;
            listConcatonator = pListConcatonator;
        }

        public PermutationDisplayer() 
        {
            fileProcessor = new FileProcessor();
            permutationCalcer = new PermutationCalcer();
            specialComparer = new SpecialComparer();
            listConcatonator = new ListConcatonator();
        }

        public List<String> displayPermsFromFile(string file)
        {

            List<string> lstPerms = new List<string>();
            List<String> lstStr = fileProcessor.GetStringsFromFile(file);

            foreach (string str in lstStr)
            {
                permutationCalcer.calcPermutations(str);
                List<string> perms = permutationCalcer.permutations;

                perms = perms.OrderBy(p => p, specialComparer).ToList();
                lstPerms.Add(listConcatonator.ConcatList(perms));
            }
            return lstPerms;

        }



    }
}
