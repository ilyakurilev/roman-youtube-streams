public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            if (dictionary.TryGetValue(target - nums[i], out var j))
            {
                result[0] = j;
                result[1] = i;
                
                return result;
            }

            dictionary.TryAdd(nums[i], i);
        }

        return result;
    }
}
