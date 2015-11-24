using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{

    /**
    House Robber
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
    **/

    [TestClass]
    public class _198
    {
        //0,0
        public int Rob(int[] nums)
        {
            if (nums == null||nums.Length==0) return 0;
            if (nums.Length == 1) return nums[0];
            var dp= new int[nums.Length+1];
            dp[0] = 0;
            dp[1] = nums[0];
            for (var i = 2; i < dp.Length; i++)
            {
                dp[i] = Math.Max(nums[i-1]+dp[i-2],dp[i-1]);
            }
            return dp[dp.Length-1];
        }

        [TestMethod]
        public void TestMethod()
        {

        


        }


    }
}
