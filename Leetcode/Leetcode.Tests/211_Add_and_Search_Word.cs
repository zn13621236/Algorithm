using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Tests
{

    /**
       Add and Search Word - Data structure design

Design a data structure that supports the following two operations:

void addWord(word)
bool search(word)
search(word) can search a literal word or a regular expression string containing only letters a-z or .. A . means it can represent any one letter.

For example:

addWord("bad")
addWord("dad")
addWord("mad")
search("pad") -> false
search("bad") -> true
search(".ad") -> true
search("b..") -> true

    **/

    [TestClass]
    public class _211_Add_and_Search_Word
    {

   

        [TestMethod]
        public void TestMethod()
        {

   

        }


    }


    public class WordDictionary
    {

        // Adds a word into the data structure.
        public void AddWord(String word)
        {

        }

        // Returns if the word is in the data structure. A word could
        // contain the dot character '.' to represent any one letter.
        public bool Search(string word)
        {
            return false;
        }
    }

    // Your WordDictionary object will be instantiated and called as such:
    // WordDictionary wordDictionary = new WordDictionary();
    // wordDictionary.AddWord("word");
    // wordDictionary.Search("pattern");
}
