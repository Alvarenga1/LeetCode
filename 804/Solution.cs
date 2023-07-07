using System.Diagnostics.Metrics;
using System.Text;

namespace _804;

public class Solution
{
    public int UniqueMorseRepresentations(string[] words)
    {

        string[] morse = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", 
            "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};

        string[] result = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            StringBuilder sb = new StringBuilder();
            for (int j =0; j < words[i].Length; j++)
            {
                int asciiValue = Convert.ToInt32(words[i][j]);
                sb.Append(morse[asciiValue-97]);
            }
            result[i] = sb.ToString();
        }

        return result.Distinct().Count();
    }
}