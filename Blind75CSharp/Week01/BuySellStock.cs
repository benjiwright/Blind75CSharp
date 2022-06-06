namespace Blind75CSharp.Week01;

public class BuySellStock
{
   public int MaxProfit(int[] prices)
   {
      int maxProfit = 0, left = 0, right = 1;

      while (right < prices.Length)
      {
         var buy = prices[left];
         var sell = prices[right];
         var profit = sell - buy;

         if (buy < sell)
         {
            maxProfit = Math.Max(profit, maxProfit);
         }
         else
         {
            left = right;
         }

         right++;
      }

      return maxProfit;
   }
}

// Runtime: 245 ms, faster than 82.58% of C# online submissions for Best Time to Buy and Sell Stock.
// Memory Usage: 49.7 MB, less than 8.02% of C# online submissions for Best Time to Buy and Sell Stock.