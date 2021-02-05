using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Reader
    {
        private StreamReader reader;
        
        public Reader(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("Файл не найден");
            }

            reader = new StreamReader(fileName);
        }

        public int NextInt()
        {
            int res;

            if (!int.TryParse(reader.ReadLine(), out res))
            {
                Close();
                throw new InvalidDataException("Не число");
            }

            return res;
        }

        public string NextString()
        {
            return reader.ReadLine();
        }

        public void Close()
        {
            reader.Close();
        }
    }
}
