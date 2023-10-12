using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SmirnovIA.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            if (n > 31 || n < 1) throw new ArgumentException($"День должен быть от 1 до 30. Значение {n}"); ;
            switch (m)
            {
                case 1: return (n + 1) + " Января";
                case 2: return (n + 1) + " Февраля" ;
                case 3: return (n + 1) + " Марта" ;
                case 4: return (n + 1) + " Апреля" ;
                case 5: return (n + 1) + " Мая";
                case 6: return (n + 1) + " Июня";
                case 7: return (n + 1) + " Июля";
                case 8: return (n + 1) + " Августа";
                case 9: return (n + 1) + " Сентября";
                case 10: return (n + 1) + " Октября";
                case 11: return (n + 1) + " Ноября";
                case 12: return (n + 1) + " Декабря";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}"); ;
            }
        }
    }
}

