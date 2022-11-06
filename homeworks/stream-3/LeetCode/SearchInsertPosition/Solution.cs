public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            if (nums[middle] == target)
            {
                return middle;
            }

            if (target < nums[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return left;
    }
}