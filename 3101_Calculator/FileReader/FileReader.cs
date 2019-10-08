using System.IO;

namespace Program
{
    public class FileReader : IFileReader
    {
        public string[] Read(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}