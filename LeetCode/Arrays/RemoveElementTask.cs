namespace LeetCode.Arrays;

public static class RemoveElementTask
{
    public static int RemoveElement(int[] nums, int val)
    {
        var counter = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[counter] = nums[i];
                counter++;
            }
        }

        return counter;
    }
}