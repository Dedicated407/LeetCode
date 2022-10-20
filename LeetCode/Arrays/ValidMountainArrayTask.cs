namespace LeetCode.Arrays;

public static class ValidMountainArrayTask
{
    public static bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3)
        {
            return false;
        }

        bool increase;

        if (arr[0] < arr[1])
        {
            increase = true;
        }
        else
        {
            return false;
        }

        for (var i = 1; i < arr.Length - 1; i++)
        {
            if (increase)
            {
                if (arr[i] > arr[i + 1])
                {
                    increase = false;
                }

                if (arr[i] == arr[i + 1])
                {
                    return false;
                }
            } 
            else
            {
                if (arr[i] <= arr[i + 1])
                {
                    return false;
                }
            }
        }

        return !increase;
    }
}