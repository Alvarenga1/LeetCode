namespace _1290;


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        int val = 0;
        string binary = "";

        while (head != null)
        {
            binary = String.Concat(binary, head.val);
            head = head.next;
        }

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i - 1] == '1')
            {
                val += (int)Math.Pow(2, i);
            }
        }


        return val;
    }
}
