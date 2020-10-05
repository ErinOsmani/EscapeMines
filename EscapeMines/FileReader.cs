using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EscapeMines
{
    public static class FileReader
    {
        public static string[] GetLinesFromFile(string path)
        {
            var lines = new List<string>();
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines.ToArray();
        }
        
    }
}
