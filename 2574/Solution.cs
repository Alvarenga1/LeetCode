namespace _2574;

public class Solution
{
    public int[] LeftRightDifference(int[] nums)
    {
        int n = nums.Length;
        int[] leftSum = new int[n];
        int[] rightSum = new int[n];
        int[] answer = new int[n];

        // calculate left sum
        leftSum[0] = 0;
        for (int i = 1; i < n; i++)
        {
            leftSum[i] = leftSum[i - 1] + nums[i - 1];
        }

        // calculate right sum
        rightSum[n - 1] = 0;
        for (int i = n - 2; i >= 0; i--)
        {
            rightSum[i] = rightSum[i + 1] + nums[i + 1];
        }

        // calculate answer
        for (int i = 0; i < n; i++)
        {
            answer[i] = Math.Abs(leftSum[i] - rightSum[i]);
        }

        return answer;

    }
}