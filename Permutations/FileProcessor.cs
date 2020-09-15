using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;

namespace Permutations
{
    public class FileProcessor
    {
        private readonly IFileSystem _fileSystem;

        public FileProcessor() : this(new FileSystem()) { }

        public FileProcessor(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public List<string> GetStringsFromFile(string inputFilePath)
        {

            List<string> inputs = new List<string>();

            if (_fileSystem.File.Exists(inputFilePath))
            {
                using (StreamReader inputReader = _fileSystem.File.OpenText(inputFilePath))
                {

                    while (!inputReader.EndOfStream)
                    {
                        string line = inputReader.ReadLine();
                        if (line.Length > 0) inputs.Add(line);
                    }

                }
            }

            return inputs;
        }
    }
}
