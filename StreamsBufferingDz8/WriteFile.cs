using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsBufferingDz8
{
    internal class WriteFile
    {
        public void WriteMyFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] bytes = new Byte[fs.Length];
                    bs.Read(bytes, 0, bytes.Length);
                    string date = Encoding.UTF8.GetString(bytes);
                    string newDate = Environment.NewLine + "Hello world!";
                    byte[] newBytes = Encoding.UTF8.GetBytes(newDate);
                    bs.Write(newBytes, 0, newBytes.Length);
                }
            }
        }
    }
}
