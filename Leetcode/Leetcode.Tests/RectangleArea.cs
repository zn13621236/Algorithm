using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{
    [TestClass]
    public class RectangleArea
    {
        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            var a1 = Math.Min(C, G);
            var a2 = Math.Max(A, E);
            var width = a1>a2?a1-a2:0;
            a1 = Math.Min(D, H);
            a2 = Math.Max(B, F);
            var height = a1 > a2 ? a1 - a2 : 0;
            return (D - B) * (C - A) + (G - E) * (H - F) - width * height;
        }



        [TestMethod]
        public void Compute()
        {
            ComputeArea(-1500000001,
                0,
                -1500000000,
                1,
                1500000000,
                0,
                1500000001,
                1);
        }
    }
}
