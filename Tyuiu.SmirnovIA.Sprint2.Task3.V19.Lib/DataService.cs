using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SmirnovIA.Sprint2.Task3.V19.Lib
{
    public class DataService : ISprint2Task3V19
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round(x * x + Math.Pow((x + 1) / (x - 1), x), 3);
            }
            else
            {
                if (x == 0)
                {
                    return Math.Round((x*x + Math.Cos(x*x) + 13) / (x*x + Math.Sin(x*x) + 9), 3);
                }
                else
                {
                    if (-23 < x && x < 2)
                    {
                        return Math.Round(Math.Pow((1 + 1/(x * x)), x), 3);
                    }
                    else
                    {
                        return Math.Round(x + 10 * x - 1 / x, 3);
                    }
                    
                }
            }
        }
    }
}
