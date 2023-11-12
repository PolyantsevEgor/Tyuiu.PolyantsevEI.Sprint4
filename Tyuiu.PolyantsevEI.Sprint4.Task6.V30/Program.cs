using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PolyantsevEI.Sprint4.Task6.V30.Lib;

namespace Tyuiu.PolyantsevEI.Sprint4.Task6.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Полянцев Е. И. | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Полянцев Егор Ильич | ИСТНб-23-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных                                             *");
            Console.WriteLine("* [Береза, Дуб, Клён, Сосна, Пихта, Осина], используя                     *");
            Console.WriteLine("* класс Array, выведите элементы массива, длина которых больше 5 символов.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] arr = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            Console.WriteLine("Массив:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Массив элементов больше 5:");

            string[] res = ds.Calculate(arr);

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
