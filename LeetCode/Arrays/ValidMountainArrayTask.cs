namespace LeetCode.Arrays;

public static class ValidMountainArrayTask
{
    public static bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3)
        {
            return false;
        }

        bool increasing = true;

        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                return false;
            }

            if (increasing)
            {
                if (arr[i - 1] > arr[i])
                {
                    increasing = false;
                }
            } 
            else
            {
                if (arr[i - 1] < arr[i])
                {
                    return false;
                }
            }

            if (i == 1 && !increasing)
            {
                return false;
            }
        }

        return !increasing;
    }
}