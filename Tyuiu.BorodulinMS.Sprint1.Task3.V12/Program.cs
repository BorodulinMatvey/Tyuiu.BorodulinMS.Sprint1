using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.Sprint1.Task3.V12.Lib;
namespace Tyuiu.BorodulinMS.Sprint1.Task3.V12
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
            Console.WriteLine("* Вариант #12                                                            *");
            Console.WriteLine("* Выполнил: Бородулин Матвей Сергеевич | ИИПб-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника  *");
            Console.WriteLine("* по длиннам двух катетов                                               .*");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double a, b;
            Console.WriteLine("Введите длину первого катета:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета:");
            b = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(ds.TriangleArea(a, b));
            Console.ReadLine();
        }
    }
}
