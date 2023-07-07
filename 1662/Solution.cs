namespace _1662;

public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string word1Result = "";
        string word2Result = "";

        for (int i = 0; i < word1.Length; i++)
        {
            word1Result = String.Concat(word1Result, word1[i]);
        }

        for (int i = 0; i < word2.Length; i++)
        {
            word2Result = String.Concat(word2Result, word2[i]);
        }

        return word1Result == word2Result;
    }
}