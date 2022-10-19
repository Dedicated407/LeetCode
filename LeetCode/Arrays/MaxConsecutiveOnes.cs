namespace LeetCode.Arrays;

public static class MaxConsecutiveOnes
{
    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxCount = 0;
        int count = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count++;
                
                if (count > maxCount) {
                    maxCount = count;
                }
            }
            else
            {
                count = 0;
            }
        }

        return maxCount;
    }
}