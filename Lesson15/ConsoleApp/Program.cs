using System;
using System.IO;
using System.IO.Compression;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Где будем искать?");
            string directory = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);

            Console.WriteLine("Какой файл нужно найти?");
            var file = Console.ReadLine();
            SearchEngine searchFile = new SearchEngine();
            var resultSearch = searchFile.Search(directoryInfo, file);

            var packArhive = Path.Combine(resultSearch.Directory.FullName, Path.GetFileNameWithoutExtension(resultSearch.FullName) + ".zip");
            using (var fileStream = new FileStream(packArhive, FileMode.Create))
            using (ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Create))
            {
                zipArchive.CreateEntryFromFile(resultSearch.FullName, resultSearch.Name);
            }

            Console.WriteLine($"Файл найден и успешно упакован. Путь к архиву: {packArhive}");
        }
    }
}
