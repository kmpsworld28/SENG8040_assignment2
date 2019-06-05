using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolution2
{
    static public class TriangleSolver
    {
        public static string Analyze(int k, int m, int p)
        {
            if (((k + m) > p) && ((k + p) > m) && ((m + p) > k))
            {
                string triangleType = "Triangle Type = ";

                if (k == m && m == p)
                {
                    return string.Format("{0} This is an Equilateral.", triangleType);
                }
                else if (k == m || m == p || k == p)
                {
                    return string.Format("{0} This is an Isosceles.", triangleType);
                }
                else 
                {
                    return string.Format("{0} This is a Scalene.", triangleType);
                }
            }
            else
            {
                return "These values can not make triangle.\n Try different values.";
            }
        }
    }
}
