using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{
    /**
Additive number is a positive integer whose digits can form additive sequence.

A valid additive sequence should contain at least three numbers. Except for the first two numbers, each subsequent number in the sequence must be the sum of the preceding two.

For example:
"112358" is an additive number because the digits can form an additive sequence: 1, 1, 2, 3, 5, 8.

1 + 1 = 2, 1 + 2 = 3, 2 + 3 = 5, 3 + 5 = 8
"199100199" is also an additive number, the additive sequence is: 1, 99, 100, 199.
1 + 99 = 100, 99 + 100 = 199
Note: Numbers in the additive sequence cannot have leading zeros, so sequence 1, 2, 03 or 1, 02, 3 is invalid.

Given a string represents an integer, write a function to determine if it's an additive number.

Follow up:
How would you handle overflow for very large input integers?


    **/
    [TestClass]
    public class _306
    {

        public bool IsAdditiveNumber(string num)
        {
            if (num == null || num.Length < 3) return false; 
            for (var i = 0; i < num.Length-2; i++)
            {
                var num1 = num.Substring(0, i + 1);
                if (num1[0] == '0'&&num1.Length>1) break;
                for (var j = i+1; j < num.Length - 1; j++)
                {                    
                    var num2 = num.Substring(i+1, j-i);//bug because c# substring is different from java substring
                    if (num2[0] == '0'&&num2.Length>1) break;
                    if (Helper(num,j+1,num1,num2))// make sure it is j+1 as string starts with should start with next char.
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Helper(string num, int index, string num1, string num2)
        {
            if (index >= num.Length) return true;
            var n1 = Convert.ToInt64(num1);
            var n2 = Convert.ToInt64(num2);
            var n3 = n1 + n2;
            var  val= Convert.ToString(n3);
            return num.Substring(index).StartsWith(val) && Helper(num,index+val.Length,num2,val);
        }

        [TestMethod]
        public void Test1()
        {
            var s1= "101";
         bool result=   IsAdditiveNumber(s1);
        }
    }
}
