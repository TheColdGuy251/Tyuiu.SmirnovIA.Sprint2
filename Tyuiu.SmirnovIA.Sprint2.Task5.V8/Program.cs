using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SmirnovIA.Sprint2.Task5.V8.Lib;

namespace Tyuiu.SmirnovIA.Sprint2.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Смирнов И. А. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный switch                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Смирнов Илья Алексеевич | ИИПб-23-3                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным n и m              *");
            Console.WriteLine("* определить дату предыдущего дня (принять, что n и m не характеризуют    *");
            Console.WriteLine("* 1 января).                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.FindDateOfPreviousDay(m, n);
            if (res == -1) Console.WriteLine("Некорректные данные");
            else Console.WriteLine("Вчера было " + res);

            Console.ReadKey();
        }
    }
}
