using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{

/**
    Minimum Size Subarray Sum

Given an array of n positive integers and a positive integer s, find the minimal length of a subarray of which the sum ≥ s. If there isn't one, return 0 instead.

For example, given the array [2,3,1,2,4,3] and s = 7,
the subarray [4,3] has the minimal length under the problem constraint.

click to show more practice.

More practice:
If you have figured out the O(n) solution, try coding another solution of which the time complexity is O(n log n).

**/

    [TestClass]
    public class _209
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
