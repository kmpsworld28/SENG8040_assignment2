using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeSolution2;
using NUnit.Framework;

namespace ShapeSolution2_Testing
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Analyze_Firstside1_inputside2_inputside3_ExpectedResult_NotTriangle()
        {

            int k = 1;
            int m = 2;
            int p = 3;

            string temp = string.Empty;

            if (((k + m) > p) && ((k + p) > m) && ((m + p) > k))
            {
                string triangleType = "Triangle Type = ";

                if (k == m && m == p)
                {
                    temp= string.Format("{0} This is an Equilateral.", triangleType);
                }
                else if (k == m || m == p || k == p)
                {
                    temp= string.Format("{0} This is an Isosceles.", triangleType);
                }
                else
                {
                    temp = string.Format("{0} This is a Scalene.", triangleType);
                }
            }

            String s = TriangleSolver.Analyze(k,m,p);

            Assert.AreEqual(s,temp);
        }
    }
    /*
    [Test]
    public void Analyze_Firstside1_inputside2_inputside3_ExpectedResult_NotTriangle()
    {

        int k = 1;
        int m = 2;
        int p = 3;

        string temp = string.Empty;

        if (((k + m) > p) && ((k + p) > m) && ((m + p) > k))
        {
            string triangleType = "Triangle Type = ";

            if (k == m && m == p)
            {
                temp = string.Format("{0} This is an Equilateral.", triangleType);
            }
            else if (k == m || m == p || k == p)
            {
                temp = string.Format("{0} This is an Isosceles.", triangleType);
            }
            else
            {
                temp = string.Format("{0} This is a Scalene.", triangleType);
            }
        }

        String s = TriangleSolver.Analyze(k, m, p);

        Assert.AreEqual(s, temp);
    }
}
[Test]
public void Analyze_Firstside1_inputside2_inputside3_ExpectedResult_NotTriangle()
{

    int k = 1;
    int m = 2;
    int p = 3;

    string temp = string.Empty;

    if (((k + m) > p) && ((k + p) > m) && ((m + p) > k))
    {
        string triangleType = "Triangle Type = ";

        if (k == m && m == p)
        {
            temp = string.Format("{0} This is an Equilateral.", triangleType);
        }
        else if (k == m || m == p || k == p)
        {
            temp = string.Format("{0} This is an Isosceles.", triangleType);
        }
        else
        {
            temp = string.Format("{0} This is a Scalene.", triangleType);
        }
    }

    String s = TriangleSolver.Analyze(k, m, p);

    Assert.AreEqual(s, temp);
}*/
    }
