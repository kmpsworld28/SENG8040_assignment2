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
        public void Analyze_Firstside1_inputside2_inputside3_ExpectedResult_Equilateral()
        {

            int k = 15;
            int m = 15;
            int p = 15;

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
            else
            {
                temp = "These values can not make triangle.\n Try different values.";
            }

            String s = TriangleSolver.Analyze(k, m, p);

            Assert.AreEqual(s, temp);
        }
        [Test]
        public void Analyze_Firstside1_inputside2_inputside3_ExpectedResult_Isosceles()
        {

            int k = 18;
            int m = 18;
            int p = 9;

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
            else
            {
                temp = "These values can not make triangle.\n Try different values.";
            }

            String s = TriangleSolver.Analyze(k, m, p);

            Assert.AreEqual(s, temp);
        }
        [Test]
        public void Analyze_Firstside1_inputside2_inputside3_ExpectedResult_Scalene()
        {

            int k = 5;
            int m = 17;
            int p = 9;

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
            else
            {
                temp = "These values can not make triangle.\n Try different values.";
            }

            String s = TriangleSolver.Analyze(k, m, p);

            Assert.AreEqual(s, temp);
        }
        [Test]
        public void Analyze_Firstside1_inputside2_inputside3_ExpectedResult_NotTriangle()
        {

            int k = 1000;
            int m = 1500;
            int p = 500;

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
            else
            {
                temp = "These values can not make triangle.\n Try different values.";
            }

            String s = TriangleSolver.Analyze(k, m, p);

            Assert.AreEqual(s, temp);
        }
    }
}
   