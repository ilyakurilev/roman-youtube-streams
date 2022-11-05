public class Solution
{
    public bool IsValid(string s)
    {
        var openParentheses= new Dictionary<char, char>
        {
            [')'] = '(',
            ['}'] = '{',
            [']'] = '['
        };

        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
                continue;
            }

            if (!stack.TryPop(out var prevParentheses))
            {
                return false;
            }

            if (prevParentheses != openParentheses[s[i]])
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}