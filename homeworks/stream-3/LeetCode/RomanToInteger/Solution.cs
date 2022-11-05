public class Solution
{
    public int RomanToInt(string s)
    {
        var arabicNumerals = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        var resultNumber = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (arabicNumerals[s[i]] < arabicNumerals[s[i + 1]])
            {
                resultNumber -= arabicNumerals[s[i]];
                continue;
            }

            resultNumber += arabicNumerals[s[i]];
        }

        resultNumber += arabicNumerals[s[^1]];

        return resultNumber;
    }
}