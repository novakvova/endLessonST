using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental2
{
    public static class TextWriterFactory
    {
        static TextWriter textWriter;
        //релиз по умолчанию
        internal static TextWriter GetTextWriter(string path) //Не должеб быть видим за пределаме нашей сборки
        {
            if (textWriter != null)
                return textWriter;

            return new StreamWriter(path, true); //файл для добавления
        }
        //релиз для теста
        public static void SetTextWriter(TextWriter mockWriter)
        {
            textWriter = mockWriter;
        }
    }
}
