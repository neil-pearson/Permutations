using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Permutations
{
    class Program
    {

        static void Main()
        {
            string basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filename = basePath + "\\Files\\Given.txt";

            FileProcessor fileProcessor = new FileProcessor();
            PermutationCalcer permutationCalcer = new PermutationCalcer();
            SpecialComparer specialComparer = new SpecialComparer();
            ListConcatonator listConcatonator = new ListConcatonator();

            List<String> strPerms = new PermutationDisplayer(fileProcessor, permutationCalcer,
                specialComparer, listConcatonator).displayPermsFromFile(filename);

            foreach (string str in strPerms)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }

    }
}
