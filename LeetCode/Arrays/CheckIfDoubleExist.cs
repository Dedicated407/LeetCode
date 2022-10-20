namespace LeetCode.Arrays;

public static class CheckIfDoubleExist
{
    public static bool CheckIfExist(int[]? arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return false;
        }

        var hashTable = new Dictionary<int, int>();
        
        foreach (var key in arr)
        {
            if (hashTable.ContainsKey(key))
            {
                hashTable[key]++;
            }
            else
            {
                hashTable[key] = 1;
            }
        }

        return hashTable.Any(x =>
        {
            if (x.Key == 0)
            {
                return x.Value > 1;
            }
            
            var key = hashTable.FirstOrDefault(kv => x.Key == kv.Key * 2).Key;
            
            return key != default;
        });
    }
}