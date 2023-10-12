using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.Sprint1.Task2.V18.Lib;

namespace Tyuiu.BorodulinMS.Sprint1.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бородултин М. С. | ИИПб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Арифсетические операторы С#                                      *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #18                                                            *");
            Console.WriteLine("* Выполнил: Бородулин Матвей Сергеевич | ИИПб-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране            .*");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int a, b, c;
            Console.WriteLine("Введите длину стороны параллелепипеда:");
            a = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину параллелепипеда:");
            b = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту параллелепипеда:");
            c = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(ds.CalculateSideSquareParallelepiped(a, b, c));
            Console.ReadLine();
        }
    }
}
