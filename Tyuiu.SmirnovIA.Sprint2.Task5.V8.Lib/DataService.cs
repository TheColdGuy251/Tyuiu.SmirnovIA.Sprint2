using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SmirnovIA.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public int FindDateOfPreviousDay(int m, int n)
        {
            if (n < 1 || n > 31) return -1;
            switch (m)
            {
                case 1:
                    if (n == 1) return 31;
                    else return n - 1;
                case 2:
                    if (n == 1) return 31;
                    else if (n > 29) return -1;
                    else return n - 1;
                case 3:
                    if (n == 1) return 28;
                    else return n - 1;
                case 4:
                    if (n == 1) return 31;
                    else if (n >= 30) return -1;
                    else return n - 1;
                case 5:
                    if (n == 1) return 30;
                    else return n - 1;
                case 6:
                    if (n == 1) return 31;
                    else if (n >= 30) return -1;
                    else return n - 1;
                case 7:
                    if (n == 1) return 30;
                    else return n - 1;
                case 8:
                    if (n == 1) return 31;
                    else return n - 1;
                case 9:
                    if (n == 1) return 31;
                    else if (n >= 30) return -1;
                    else return n - 1;
                case 10:
                    if (n == 1) return 30;
                    else return n - 1;
                case 11:
                    if (n == 1) return 31;
                    else if (n >= 30) return -1;
                    else return n - 1;
                case 12:
                    if (n == 1) return 30;
                    else return n - 1;
                default: return -1;
            }
        }
    }
}
