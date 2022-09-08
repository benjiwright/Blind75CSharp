namespace Blind75CSharp.FangPopular.Google;

public class Cards
{
   public int MaxScore(int[] cardPoints, int k)
   {
      var max = 0;
      var left = 0;
      var right = cardPoints.Length - k;

      // O(k)
      for (var i = right; i < cardPoints.Length; i++)
      {
         max += cardPoints[i];
      }

      var currMax = max;
      while (right < cardPoints.Length)
      {
         currMax += cardPoints[left] - cardPoints[right];
         max = Math.Max(currMax, max);
         left++;
         right++;
      }

      return max;
   }
}