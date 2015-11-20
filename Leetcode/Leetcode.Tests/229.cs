using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{

    /**
      
       Majority Element II
        Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times. The algorithm should run in linear time and in O(1) space.


    **/

    [TestClass]
    public class _229
    {
        public IList<int> MajorityElement(int[] nums)
        {
            if (nums.Length < 2) return new List<int>(nums);
            IList<int> result = new List<int>();
            var n1 = 0;
            var n2 = 0;
            var c1 = 0;
            var c2 = 0;
            foreach (var i in nums)
            {
                if (i == n1) c1++;
                else if (i == n2) c2++;
                else if (c1 == 0)
                {
                    n1 = i;
                    c1 = 1;
                }
                else if (c2 == 0)
                {
                    n2 = i;
                    c2 = 1;
                }
                else
                {
                    c1--;
                    c2--;
                }
            }
            c1 = 0;
            c2 = 0;
            foreach (var t in nums)
            {
                if (t == n1) c1++;
                if (t == n2) c2++;
            }
            if (c1 > nums.Length / 3) result.Add(n1);
            if (c2 > nums.Length / 3 && n2 != n1) result.Add(n2);
            return result;
        }

        [TestMethod]
        public void TestMethod()
        {



        }


    }
}
