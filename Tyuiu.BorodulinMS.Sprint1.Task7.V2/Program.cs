using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.Sprint1.Task7.V2.Lib;

namespace Tyuiu.BorodulinMS.Sprint1.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бородултин М. С. | ИИПб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Арифсетические операторы С#                                     *");
            Console.WriteLine("* Задание #0                                                            *");
            Console.WriteLine("* Вариант #2                                                            *");
            Console.WriteLine("* Выполнил: Бородулин Матвей Сергеевич | ИИПб-23-1                      *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные*");
            Console.WriteLine("* и вычисляет результат по формуле:sin(x)+cos(y)/cos(x)-sin(y)*tg(x*y)  *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");

            double x, y;
            Console.WriteLine("Введите первое значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе значение y:");
            y = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
