namespace Blind75CSharp.Week06;

public class Bananas
{
   public int MinEatingSpeed(int[] piles, int h)
   {
      int left = 1, right = piles.Max();
      var result = right;

      while (left <= right)
      {
         var mid = left + (right - left) / 2;
         long hours = 0;
         foreach (var pile in piles)
         {
            hours += (int) Math.Ceiling(pile / (double) mid);
         }

         if (hours <= h)
         {
            result = Math.Min(result, mid);
            right = mid - 1;
         }
         else
         {
            left = mid + 1;
         }
      }

      return result;
   }
   // Runtime: 139 ms, faster than 83.28% of C# online submissions for Koko Eating Bananas.
   // Memory Usage: 44.9 MB, less than 38.39% of C# online submissions for Koko Eating Bananas.
}