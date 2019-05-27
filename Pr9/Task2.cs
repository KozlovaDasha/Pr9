using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr9
{
    class Task2
    {
        //static void Main()
        //{
        //    using (StreamReader file = new StreamReader("for2task.txt", Encoding.UTF8))
        //    {
        //        ReadFiles(file, Print);
        //        ReadFiles(file, PrintAllDigits);
        //        ReadFiles(file, ChangeWhitespaces);
        //    }
        //    Console.ReadLine();
        //}

        // Общий метод который принимает делегат.
        private static void ReadFiles(StreamReader someFile, Action<StreamReader> someAct)
        {
            someAct(someFile);
        }

        // Метод для вывода содержимого файла в консоль.
        private static void Print(StreamReader someFile)
        {
            Console.WriteLine(someFile.ReadToEnd());
            Console.WriteLine();
            someFile.BaseStream.Position = 0;
        }

        // Метод для вывода всех цифр в файле.
        private static void PrintAllDigits(StreamReader someFile)
        {
            var digits = from d in someFile.ReadToEnd() where char.IsDigit(d) select d;

            Console.WriteLine("Here is digits:");

            foreach (var digit in digits)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();

            someFile.BaseStream.Position = 0;
        }

        // Метод для замены определенных символов на пробелы.
        private static void ChangeWhitespaces(StreamReader someFile)
        {
            Console.WriteLine("Changing whitespaces");

            string temp = someFile.ReadToEnd();

            temp = temp.Replace(',', ' ');
            temp = temp.Replace('.', ' ');
            temp = temp.Replace('*', ' ');

            someFile.Close();

            File.Delete("for2task.txt");

            using (StreamWriter newFile = new StreamWriter("for2task.txt"))
            {
                newFile.WriteLine(temp);
            }
        }
    }
}
