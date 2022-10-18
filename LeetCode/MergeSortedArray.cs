namespace LeetCode;

public static class MergeSortedArray
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int length = nums1.Length;
        
        foreach (var i in nums2)
        {
            length--;
            nums1[length] = i;
        }
        
        Array.Sort(nums1);
    }
}