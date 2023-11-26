using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsBufferingDz8
{
    internal class ReaderFile
    {
        public void ReaderMyFile(string path, string findLine)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("no file");
            }

            using (StreamReader sr = new StreamReader(path))
            {
                bool flag = false;
                while (!sr.EndOfStream)
                {
                   
                    string value = sr.ReadLine();
                    if (value.Contains(findLine))
                    {
                        Console.WriteLine(value);
                        flag = true;
                    }

                }

                if (!flag)
                {
                    Console.WriteLine("Таких строк в файле нет.");
                }
            }
        }
    }
}
