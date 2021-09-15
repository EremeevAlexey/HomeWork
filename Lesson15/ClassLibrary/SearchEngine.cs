using System;
using System.IO;


namespace ClassLibrary
{
    public class SearchEngine
    {
        public FileInfo Search(DirectoryInfo directoryInf, string fileName)
        {
            foreach (var file in directoryInf.GetFiles())
            {
                if (fileName == file.Name)
                {
                    return file;
                }

            }
            foreach (var directory in directoryInf.GetDirectories())
            {
                try
                {
                    return Search(directory, fileName);
                }
                catch (FileNotFoundException)
                {

                }
            }
            throw new FileNotFoundException($"Файл {fileName} не найден");

        }
    }
}
