using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{
    [TestClass]
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            var i = 0;
            while (i < nums.Length && nums[i] != 0) { i++; }
            if (i == nums.Length) return;
            var j = i + 1;
            while (j < nums.Length)
            {
                if (nums[j] != 0)
                {
                    Swap(nums, i, j);
                    i++;
                }
                j++;
            }
        }
        public void Swap(int[] nums, int i, int j)
        {
            var tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }

        [TestMethod]
        public void TestMethod1()
        {
        
        }
    }
}
