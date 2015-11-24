using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{

    /**
   House Robber II
Note: This is an extension of House Robber.

After robbing those houses on that street, the thief has found himself a new place for his thievery so that he will not get too much attention. This time, all houses at this place are arranged in a circle. That means the first house is the neighbor of the last one. Meanwhile, the security system for these houses remain the same as for those in the previous street.

Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
    **/

    [TestClass]
    public class _213
    {

        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0],nums[1]);
            //not using the last element
            var dp = new int[nums.Length + 1];
            dp[0] = 0;
            dp[1] = nums[0];
            for (var i = 2; i < dp.Length-1; i++)
            {
                dp[i] = Math.Max(nums[i - 1] + dp[i - 2], dp[i - 1]);
            }
            //not using the first element
            var dp2 = new int[nums.Length + 1];
            dp2[0] = 0;
            dp2[1] = nums[1];
            for (var i = 2; i < dp.Length-1; i++)
            {
                dp2[i] = Math.Max(dp2[i-1],nums[i]+dp2[i-2]);
            }
            return Math.Max(dp[dp.Length - 2],dp2[dp2.Length-2]);
        }

        [TestMethod]
        public void TestMethod()
        {

        


        }


    }
}
