using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{

    /**

  Given an array of integers, find out whether there are two distinct indices i and j in the array such that the difference between nums[i] and nums[j] is at most t and the difference between i and j is at most k.

    **/

    [TestClass]
    public class _220
    {

        // use 2 ponters
        public int MinSubArrayLen(int s, int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int left=0, right = left, rightMark = right;
            var sum = 0;
            var minLen =int.MaxValue;
            while (left < nums.Length)
            {
                if (right!=0&&right == rightMark)
                {
                    sum -= nums[left - 1];
                }
                while (sum<s&&right<nums.Length)
                {
                    sum += nums[right];
                    right++;
                }
                if (sum >= s) {
                    minLen = Math.Min(right - left, minLen);
                }
                rightMark = right;
                left++;
            }
            return minLen==int.MaxValue?0:minLen;
        }

        [TestMethod]
        public void TestMethod()
        {

         int result=   MinSubArrayLen(3, new int[] { 1,1});


        }


    }
}
