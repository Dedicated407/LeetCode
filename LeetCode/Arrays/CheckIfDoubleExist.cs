namespace LeetCode.Arrays;

public static class CheckIfDoubleExist
{
    public static bool CheckIfExist(int[] arr)
    {
        var values = new HashSet<int> {arr[0]};

        foreach (var element in arr)
        {
            if (values.Contains(element * 2) || element % 2 == 0 && values.Contains(element / 2))
            {
                return true;
            }

            values.Add(element);
        }

        return false;
    }
}