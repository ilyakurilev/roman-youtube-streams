public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var charsInS = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!charsInS.TryAdd(s[i], 1))
            {
                charsInS[s[i]]++;
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (!charsInS.TryGetValue(t[i], out var count) || count == 0)
            {
                return false;
            }

            charsInS[t[i]]--;
        }

        return true;
    }
}