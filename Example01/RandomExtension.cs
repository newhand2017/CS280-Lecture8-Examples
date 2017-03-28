using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExtensions
{
    //Static Class
    public static class RandomExtension
    {
        //-------------------------------------------------
        // Creat Random Number for Other Projects
        //-------------------------------------------------
        public static double NextDouble(this Random random, double from, double to)
        {
            double result = (to - from) * random.NextDouble() + from;

            return result;
        }

        //-------------------------------------------------
    }
}