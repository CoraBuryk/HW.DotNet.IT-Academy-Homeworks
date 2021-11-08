using System;
using System.IO;

namespace HW02.Image
{
    class Program
    {
        static void Main(string[] args)
        {
            // Используется StreamReader для чтения строк данных из стандартного текстового файла.
            // 1. Указать путь нужного файла в компьютере пользователя
            StreamReader TextReader = new StreamReader(@"C:\Users\vovab\Downloads\image.txt", true);
            // TextReader.ReadToEnd - Считывает все символы, начиная с текущей позиции до конца потока.
            // 2. Присваивание типа String для считываемых данных в текстовом документе
            string textReaderResult = TextReader.ReadToEnd();
            TextReader.Dispose();
            // string[] - массив строк; textReaderResult.Split - возвращает строковый массив, содержащий подстроки данного экземпляра,
            // разделенные элементами заданной строки или массива знаков Юникода.
            // 3.Создание строчного массива для textReaderResult
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            // С помощью оператора new можно также создать экземпляр массива
            // 4. Преобразование строчного массива в массив байтов
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            // 5. Создание цикла для массива байтов 
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                // 6. Присваивание строке байтового значения                        
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            // 7.Конечный путь преобразованного файла
            File.WriteAllBytes(@"C:\Users\vovab\Downloads\image.png", imageBytes);
        }
    }
}