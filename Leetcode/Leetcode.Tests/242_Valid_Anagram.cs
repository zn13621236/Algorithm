using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{
    [TestClass]
    public class ValidAnagram
    {

        [TestMethod]
        public void test()
        {
            IsAnagram("a", "b");
        }

        public bool IsAnagram(string s, string t)
        {
           var c1=s.ToCharArray();                 
               Array.Sort(c1);
            var c2 = t.ToCharArray();
            Array.Sort(c2);
            if (c1.Length != c2.Length)
                return false;          
            return !c1.Where((t1, i) => t1 != c2[i]).Any();
        }

        public void test123()
        {
        }
    }
}
