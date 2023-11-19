using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FedorenkoKS.Sprint5.Task3.V25.Lib;
using System.IO;

namespace Tyuiu.FedorenkoKS.Sprint5.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Федоренко К.С. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task3                                                           *");
            Console.WriteLine("*Вариант #25                                                              *");
            Console.WriteLine("*Выполнил: Федоренко Кирилл Сергеевич | ИСПб 23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            // Место решения задания
            DataService service1 = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = 3                                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string path = service1.SaveToFileTextData(3);
            Console.WriteLine("File is written                                                           *");
            Console.WriteLine("***************************************************************************");
            double text;
            using (var reader = new BinaryReader(File.Open(path, FileMode.Open), Encoding.UTF8))
            {
                text = reader.ReadDouble();
            }
            Console.WriteLine(text.ToString());
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}