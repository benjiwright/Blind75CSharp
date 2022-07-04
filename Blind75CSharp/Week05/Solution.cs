namespace Blind75CSharp.Week05;

public class Solution
{
   public int ClimbStairs(int n)
   {
      var one = 1;
      var two = 1;

      for (var i = 0; i < n - 1; i++)
      {
         var temp = one;
         one = one + two;
         two = temp;
      }

      return one;
   }
   // Runtime: 39 ms, faster than 31.73% of C# online submissions for Climbing Stairs.
   // Memory Usage: 25.1 MB, less than 67.06% of C# online submissions for Climbing Stairs.
}