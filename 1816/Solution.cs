namespace _1816;

public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        var test = s.Split(' ');
        string[] result = new string[k];
        Array.Copy(test, result, k);

        return String.Join("",result);
    }
}