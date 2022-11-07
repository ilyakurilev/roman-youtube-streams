var solution = new Solution();
int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
int val = 2;
Console.WriteLine($"{solution.RemoveElement(nums, val)}, [{string.Join(", ", nums)}]");