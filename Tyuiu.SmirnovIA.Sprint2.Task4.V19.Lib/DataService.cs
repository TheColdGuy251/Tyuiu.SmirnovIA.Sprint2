using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SmirnovIA.Sprint2.Task4.V19.Lib
{
    public class DataService : ISprint2Task4V19
    {
        public double Calculate(double x, double y)
        {
            double z = (x / 2 < y - 6) ? Math.Round(Math.Pow(6 + 4 / (y * y), x), 3) : Math.Round((x * x - Math.Pow(Math.Cos(y), 2) + 10) / (y * y - Math.Pow(Math.Sin(y), 2) + 12), 3);
            return z;
        }
    }
}
