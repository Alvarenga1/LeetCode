using System.Text;

namespace _1678;

public class Solution
{
    public string Interpret(string command)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == 'G')
            {
                sb.Append("G");
            }
            else if (command[i] == '(' && command[i + 1] == ')')
            {
                sb.Append("o");
                i++;
            }
            else
            {
                sb.Append("al");
                i += 3;
            }
        }
        return sb.ToString();
    }
}