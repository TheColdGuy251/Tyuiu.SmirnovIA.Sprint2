using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SmirnovIA.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (y <= x*x && x >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
