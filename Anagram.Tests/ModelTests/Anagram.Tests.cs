using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace Anagram.Test
{
    [TestClass]
    public class AnagramCheckerTest
    {

        [TestMethod]
        public void CheckDatAnagram_CheckNoPass_NoReturn()
        {
            List<string> listOfWords = new List<string>() {};
            CollectionAssert.AreEqual(listOfWords, AnagramChecker.CheckDatAnagram("vegetables horseradish montana", "cart"));
        }
        [TestMethod]
        public void CheckDatAnagram_CheckOneWord_Cat()
        {
            List<string> listOfWords = new List<string>() {"cat"};
            CollectionAssert.AreEqual(listOfWords, AnagramChecker.CheckDatAnagram("cat", "cart"));
        }

        [TestMethod]
        public void CheckDatAnagram_CheckTwoWord_Cat()
        {
            List<string> listOfWords = new List<string>() { "cat", "act" };
        CollectionAssert.AreEqual(listOfWords, AnagramChecker.CheckDatAnagram("cat dog act", "cart"));
        }

        [TestMethod]
        public void CheckDatAnagram_CheckDuplicateLetterUsage_Cat()
        {
            List<string> listOfWords = new List<string>() { "dog" };
            CollectionAssert.AreEqual(listOfWords, AnagramChecker.CheckDatAnagram("egg dog", "dodge"));
        }

    }
}