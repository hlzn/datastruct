using System.Collections.Generic;
using System.IO;

public class In
{
    private static string _fileLocations = "C:\\Dev\\Lab\\dotnet\\datastruct\\data\\";
    public static IEnumerable<int> ReadInts(string fileName)
    {
        string filePath = _fileLocations + fileName;
        using(TextReader reader = File.OpenText(filePath))
        {
            string lastLine;
            while ((lastLine = reader.ReadLine()) != null)
            {
                yield return int.Parse(lastLine);
            }
        }
    }
}