namespace Blind75CSharp.Week05;

// Runtime: 305 ms, faster than 50.67% of C# online submissions for Random Pick with Weight.
// Memory Usage: 56.1 MB, less than 16.37% of C# online submissions for Random Pick with Weight.
public class RandomPick
{
   private readonly int _totalWeight;
   private readonly int[] _numbers;

   public RandomPick(int[] w)
   {
      // _totalWeight = w.Sum();
      _numbers = new int[w.Length];

      var idx = 0;
      for (var i = 0; i < w.Length; ++i)
      {
         idx += w[i];
         _numbers[i] = idx;
      }

      _totalWeight = idx;
   }

   public int PickIndex()
   {
      var r = new Random();
      var target = r.NextDouble() * _totalWeight;
      for (var i = 0; i < _numbers.Length; i++)
      {
         if (target < _numbers[i]) return i;
      }

      return -1;
   }
}