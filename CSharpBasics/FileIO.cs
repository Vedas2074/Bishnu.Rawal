using System;
using System.IO;

namespace FileDirectoryHandling
{
    public class FileIO
    {        
        public void LearnFileReading()
        {   
            string fileContent = File.ReadAllText(@"D:\Computer Science\.NET Centric Computing\Lab\Vedas-Lab\Test.txt");
            Console.WriteLine(fileContent);
        }

        public void LearnFileWriting()
        {
            File.WriteAllText("A.html", "I am new file just created.");
        }

        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.html");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;

            Console.WriteLine($"File Size: {x} bytes");
            Console.WriteLine($"Created: {y}");
            Console.WriteLine($"Directory: {z}");
        }

        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText(@"ABC\a.bishnu", "This is my own file.");
        }

        internal void LearnDirectoryInfo()
        {
            string folderPath = @"D:\Computer Science\.NET Centric Computing\Lab\Vedas-Lab\Bishnu.Rawal\CSharpBasics";
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            var files = directory.GetFiles();
            Console.WriteLine("File count: " + files.Length);
        }
    }
}
