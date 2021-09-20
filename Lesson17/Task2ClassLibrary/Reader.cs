using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task2ClassLibrary
{
    public class Reader
    {
        static Semaphore semaphore = new Semaphore(1, 2);
        public void ReadFile(string fileName)
        {
            semaphore.WaitOne();
            
            using (StreamReader reader = File.OpenText(fileName))
            {
                string read;

                while ((read = reader.ReadLine()) != null)
                {
                    var file3 = @"C:\test\testFile3.txt";
                    using (StreamWriter streamWriter = new StreamWriter(file3, true))
                    {
                        streamWriter.WriteLine(read);
                    }

                }
            }
            semaphore.Release();
        }
    }
}