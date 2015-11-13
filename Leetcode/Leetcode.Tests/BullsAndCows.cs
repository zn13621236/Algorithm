using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{
    [TestClass]
    public class BullsAndCows
    {

        public string GetHint(string secret, string guess)
        {
            var A = 0;
            var B = 0;
            var cnt = new int[10];
            for (var i = 0; i < secret.Length; ++i)
            {
                if (secret[i] == guess[i]) ++A;
                else
                {
                    if (++cnt[secret[i] - '0'] <= 0) ++B;
                    if (--cnt[guess[i] - '0'] >= 0) ++B;
                }
            }
            return A + "A" + B + "B";
        }

        [TestMethod]
        public void TestMethod1()
        {
            GetHint("1807", "7810");
        }
    }
}
