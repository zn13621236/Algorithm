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
    public class _41
    {
        public int firstMissingPositive(int[] nums)
        {
            if (nums == null) return -1;
            int i = 0;
            while (i < nums.Length)
            {
                if (i + 1 != nums[i] && nums[i] - 1 >= 0 && nums[i] - 1 < nums.Length && nums[nums[i] - 1] != nums[i])
                {
                    int tmp = nums[nums[i] - 1];
                    nums[nums[i] - 1] = nums[i];
                    nums[i] = nums[nums[i] - 1];
                    
                }
                else
                {
                    i++;
                }
            }
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1) { return j + 1; }
            }
            return nums.Length + 1;
        }

        [TestMethod]
        public void TestMethod()
        {
            var nums = new int[]{ 2, 1 };

            firstMissingPositive(nums);

        }


    }
}
