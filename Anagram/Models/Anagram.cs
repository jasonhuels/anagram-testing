using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramChecker
    {

        public static List<string> CheckDatAnagram(string wordsToCheck, string mainWord)
        {
            List<string> listOfWords = new List<string>();
            char[] mainWordArray = mainWord.ToCharArray();
            string[] arrayOfWords = wordsToCheck.Split(' ');

            for(int i=0; i<arrayOfWords.Length; i++)
            {
                char[] copy = new char[mainWordArray.Length];
                Array.Copy(mainWordArray, 0, copy, 0, mainWordArray.Length);

                for(int j = 0; j<arrayOfWords[i].Length; j++)
                {

                    int pos = Array.IndexOf(copy, arrayOfWords[i][j]);
                    if (pos >= 0)
                    {
                        copy[pos] = '*';
                        if(j == arrayOfWords[i].Length-1)
                        {
                            listOfWords.Add(arrayOfWords[i]);
                        }
                    } else {
                        continue;
                    }
                }
            }

            return listOfWords;
        }
    }
}