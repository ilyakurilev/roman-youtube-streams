public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int bestProfit = 0;
        int minPrice = int.MaxValue;

        for (int i = 0; i < prices.Length; i++)
        {
            int profit = prices[i] - minPrice;

            if (profit > bestProfit)
            {
                bestProfit = profit;
            }

            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
        }

        return bestProfit;
    }
}