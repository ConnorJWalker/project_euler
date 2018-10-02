using System;
using System.IO;

namespace ProjectEuler
{
    public class FileReader
    {
        public string ReadFile(string fileName) => 
            File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}../../TextFiles/{fileName}.txt");

        public string[] ReadFileArray(string fileName) => 
            File.ReadAllLines($"{AppDomain.CurrentDomain.BaseDirectory}../../TextFiles/{fileName}.txt");
    }
}
