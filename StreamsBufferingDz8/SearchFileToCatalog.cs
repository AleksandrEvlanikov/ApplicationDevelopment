using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace StreamsBufferingDz8
{
    internal class SearchFileToCatalog
    {

        public string SearchFile(string searchFileName)
        {
            string catalog = @"C:\Users\aleks\OneDrive\Рабочий стол\C#pog\ddf";
            FileInfo fileInfo = new FileInfo(catalog);
            string filePath = Path.Combine(catalog, "1.txt");

            if (!File.Exists(filePath))
            {

                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    string newDate = Environment.NewLine + "Hello world!";
                    byte[] data = Encoding.UTF8.GetBytes(newDate);
                    fs.Write(data, 0, data.Length);
                    Console.WriteLine("Файл создан.");
                }

            }
            foreach (string findFile in Directory.EnumerateFiles(catalog, searchFileName, SearchOption.AllDirectories))
            {
                fileInfo = new FileInfo(findFile);
                Console.WriteLine($"Полный путь = {fileInfo.FullName}, Вес файла = {fileInfo.Length} байт");
                
            }
            return fileInfo.FullName;
        }
    }
}
