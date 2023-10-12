using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SmirnovIA.Sprint2.Task6.V9.Lib;

namespace Tyuiu.SmirnovIA.Sprint2.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Смирнов И. А. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Смирнов Илья Алексеевич | ИИПб-23-3                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным n и m              *");
            Console.WriteLine("* определить дату следующего дня (принять, что n и m не характеризуют     *");
            Console.WriteLine("* 31 декабря).                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер дня: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (m > 12 || m < 1 || n < 1 || n > 30)
            {
                Console.WriteLine("Некорректные данные");
            }
            else 
            {
                string res = ds.FindDateOfNextDay(m, n);
                Console.WriteLine("Завтра будет " + res);
            }

            Console.ReadKey();
        }
    }
}
