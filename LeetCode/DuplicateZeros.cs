namespace LeetCode;

public static class DuplicateZeros
{
    public static void DoubleZeros(int[] arr)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0) continue;
            
            for (var j = arr.Length - 1; j > i; j--)
            {
                arr[j] = arr[j - 1];
            }
            
            i++;
        }
    }
}