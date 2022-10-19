namespace LeetCode.Arrays;

public static class RemoveDuplicatesFromSortedArray
{
    public static int RemoveDuplicates(int[] nums)
    {
        int counter = 0;
        
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[counter] < nums[i])
            {
                counter++;
                nums[counter] = nums[i];
            }
        }

        return counter + 1;
    }
}