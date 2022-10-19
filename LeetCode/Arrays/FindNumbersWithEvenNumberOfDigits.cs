namespace LeetCode.Arrays;

public static class FindNumbersWithEvenNumberOfDigits
{
    public static int FindNumbers(int[] nums)
    {
        var counter = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i].ToString().Length % 2 == 0)
            {
                counter++;
            }
        }

        GC.Collect();
        
        return counter;
    }
}