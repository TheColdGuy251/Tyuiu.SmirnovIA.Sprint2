using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SmirnovIA.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((1 < x) && (x < 14) && (y > 1) && (y < 14))
            {
                if ((y == 2) && (x > 9) && (x < 14)) return true;
                if ((y == 3) && ((x > 2) && (x < 6) || (x > 9) && (x < 14))) return true;
                if ((y == 4) && ((x > 1) && (x < 6) || (x > 9) && (x < 13))) return true;
                if ((y == 5) && (x > 1) && (x < 13)) return true;
                if ((y == 6 || y == 7) && (x > 2) && (x < 9)) return true;
                if ((y > 7) && (y < 11) && (x > 5) && (x < 9)) return true;
                if (y == 11 && (x > 2) && (x < 14)) return true;
                if (y == 12 && (x > 6) && (x < 11)) return true;
                if (y == 12 && (x > 6) && (x < 11)) return true;
                if (y > 8 && y < 14 && x == 13) return true;

            }
            return false;
        }
    }
}
