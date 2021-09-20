using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Task2ClassLibrary;

namespace Task2ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var testDir = @"C:\test";
            new DirectoryInfo(testDir).Create();

            var file1 = @"C:\test\testFile1.txt";
            using (StreamWriter streamWriter = new (file1, true))
            {
                streamWriter.WriteLine("Какой-то текст");
            }

            var file2 = @"C:\test\testFile2.txt";
            using (StreamWriter streamWriter = new (file2, true))
            {
                streamWriter.WriteLine("И здесь какой-то текст");
            }

            var file3 = @"C:\test\testFile3.txt";
            using FileStream stream = new (file3, FileMode.OpenOrCreate);

            Reader reader = new Reader();
            new Thread(() => { reader.ReadFile(file1); }).Start();

            new Thread(() => { reader.ReadFile(file2); }).Start();



           

        }
    }
}
