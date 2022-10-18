namespace LeetCode;

public static class SquaresOfSortedArray
{
    /// <summary>
    /// Given an integer array nums sorted in non-decreasing order.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns>an array of the squares of each number sorted in non-decreasing order</returns>
    public static int[] SortedSquares(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] *= nums[i];
        }
        
        Array.Sort(nums);
        
        GC.Collect();

        return nums;
    }
    
    // Other solution
    // public static int[] SortedSquares(int[] nums) =>
    //     nums.Select(x => x * x).OrderBy(x => x).ToArray();
}