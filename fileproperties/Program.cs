using System;
using System.Collections.Generic;
using System.IO;

namespace fileproperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //to get the file names only
            string rootpath = @"C:\Users\opilane\samples";
            string[] files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            List<string> lines = new List<string>();

            foreach(string file in files)
            {
                //Console.WriteLine(file); (uncommented)
                //get file objects
                var fileData = new FileInfo(file);
                Console.WriteLine(fileData);
                string fileName = fileData.Name;
                string fileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                Console.WriteLine($"File name: {fileDirectory}; size: {fileSize}; location: {fileDirectory}");
                string line = $"File name: {fileDirectory}; size: {fileSize}; location: {fileDirectory}";
                lines.Add(line);
            }

            string fileDataPath = @"C:\Users\opilane\samples\filedata.txt";
            File.WriteAllLines(fileDataPath, lines);
        }
    }
}
